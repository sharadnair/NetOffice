#include "stdafx.h"
#include "DllRegisterMode.hpp"

namespace ShimLoader_Register32On64
{
	DWORD _regKeyOptions = KEY_ALL_ACCESS;

	HRESULT RegisterCOMComponent(HINSTANCE module, LPCWSTR officeApplication, LPCWSTR progId, LPCWSTR classId, LPCWSTR version, LPCWSTR description, RegisterMode mode);
	HRESULT UnregisterCOMComponent(LPCWSTR officeApplication, LPCWSTR progId, LPCWSTR classId, LPCWSTR version, RegisterMode mode);
	HRESULT RegisterCOMAddin(LPCWSTR pszOfficeApp, LPCWSTR pszProgID, LPCWSTR pszFriendlyName, LPCWSTR pszDescription, DWORD dwStartupContext, DWORD dwCommandLineSafe, bool registerPerMachine);
	HRESULT UnRegisterCOMAddin(LPCWSTR pszOfficeApp, LPCWSTR pszProgID, bool registerPerMachine);

	HKEY TargetRootKey(RegisterMode mode);
	void ProgIdSubKey(LPCWSTR progId, RegisterMode mode, WCHAR* progIdKey);
	void ClassIdSubKey(LPCWSTR classId, RegisterMode mode, WCHAR* classIdKey);
	BOOL SetKeyAndValue(HKEY hKeyRoot, LPCWSTR pszPath, LPCWSTR pszSubkey1, LPCWSTR pszSubkey2, LPCWSTR pszvalueName, LPCWSTR pszValue);
	LONG RecursiveDeleteKey(HKEY hKeyParent, LPCWSTR pszKeyChild);

	HRESULT DllRegister(HINSTANCE module, LPCWSTR officeApplication, DWORD addinLoadBehavior, DWORD addinCommandLineSafe, LPCWSTR progId, LPCWSTR classId, LPCWSTR friendlyName, LPCWSTR description, LPCWSTR version, RegisterMode mode)
	{
		HRESULT result = S_OK;

		result = RegisterCOMComponent(module, officeApplication, progId, classId, version, description, mode);
		if (S_OK == result)
			result = RegisterCOMAddin(officeApplication, progId, friendlyName, description, addinLoadBehavior, addinCommandLineSafe, 0 == mode);

		return result;
	}

	HRESULT DllUnregister(LPCWSTR officeApplication, LPCWSTR progId, LPCWSTR classId, LPCWSTR version, RegisterMode mode)
	{
		HRESULT result = S_OK;

		UnRegisterCOMAddin(officeApplication, progId, 0 == mode);
		result = UnregisterCOMComponent(officeApplication, progId, classId, version, mode);

		return result;
	}

	HRESULT RegisterCOMComponent(HINSTANCE module, LPCWSTR officeApplication, LPCWSTR progId, LPCWSTR classId, LPCWSTR version, LPCWSTR description, RegisterMode mode)
	{
		HRESULT result = S_OK;

		WCHAR moduleFullFileName[512];
		DWORD dwResult = ::GetModuleFileName(module, moduleFullFileName, 512);
		if (0 == dwResult)
			return E_FAIL;

		HKEY targetRootKey = TargetRootKey(mode);

		WCHAR classIdKey[512];
		ClassIdSubKey(classId, mode, classIdKey);

		WCHAR progIdKey[512];
		ProgIdSubKey(progId, mode, progIdKey);

		// Target Key ProgId
		if (!SetKeyAndValue(targetRootKey, progIdKey, NULL, NULL, NULL, progId))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, progIdKey, L"CLSID", NULL, NULL, classId))
			return S_FALSE;

		// Target Key IID
		if (!SetKeyAndValue(targetRootKey, classIdKey, NULL, NULL, NULL, progId))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, classIdKey, L"InprocServer32", NULL, NULL, moduleFullFileName))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, classIdKey, L"InprocServer32", NULL, L"ThreadingModel", L"Apartment"))
			return S_FALSE;
		if (!SetKeyAndValue(targetRootKey, classIdKey, L"ProgId", NULL, L"", progId))
			return S_FALSE;

		// HKEY_CLASSES_ROOT ProgId
		if (!SetKeyAndValue(HKEY_CLASSES_ROOT, progId, NULL, NULL, NULL, progId))
			return S_FALSE;
		if (!SetKeyAndValue(HKEY_CLASSES_ROOT, progId, L"CLSID", NULL, NULL, classId))
			return S_FALSE;

		// HKEY_CLASSES_ROOT IID
		if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", progId, NULL, NULL, progId))
			return S_FALSE;
		if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", progId, L"InprocServer32", NULL, moduleFullFileName))
			return S_FALSE;
		if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", progId, L"InprocServer32", L"ThreadingModel", L"Apartment"))
			return S_FALSE;
		if (!SetKeyAndValue(HKEY_CLASSES_ROOT, L"CLSID", progId, L"ProgId", NULL, progId))
			return S_FALSE;

		return result;
	}

	HRESULT UnregisterCOMComponent(LPCWSTR officeApplication, LPCWSTR progId, LPCWSTR classId, LPCWSTR version, RegisterMode mode)
	{
		HRESULT result = S_OK;

		HKEY hKeyRoot = TargetRootKey(mode);
		WCHAR classIdKey[512];
		ClassIdSubKey(classId, mode, classIdKey);
		WCHAR progIdKey[512];
		ProgIdSubKey(progId, mode, progIdKey);

		if (ERROR_SUCCESS != RecursiveDeleteKey(HKEY_CLASSES_ROOT, progId))
			result = E_FAIL;
		if (ERROR_SUCCESS != RecursiveDeleteKey(hKeyRoot, classIdKey))
			result = E_FAIL;
		if (ERROR_SUCCESS != RecursiveDeleteKey(hKeyRoot, progIdKey))
			result = E_FAIL;

		return result;
	}

	HRESULT RegisterCOMAddin(LPCWSTR pszOfficeApp, LPCWSTR pszProgID, LPCWSTR pszFriendlyName, LPCWSTR pszDescription, DWORD dwStartupContext, DWORD dwCommandLineSafe, bool registerPerMachine)
	{
		HRESULT hr = S_OK;
		WCHAR szKeyBuf[1024];
		DWORD dwTemp = 0;
		bool keyCreated = false;
		HKEY hKey;

		lstrcpy(szKeyBuf, L"Software\\Microsoft\\Office\\");
		lstrcat(szKeyBuf, pszOfficeApp);
		lstrcat(szKeyBuf, L"\\Addins\\");
		lstrcat(szKeyBuf, pszProgID);

		HKEY root = registerPerMachine ? HKEY_LOCAL_MACHINE : HKEY_CURRENT_USER;
		IfFailGo(RegCreateKeyEx(root, szKeyBuf, 0, NULL, REG_OPTION_NON_VOLATILE, _regKeyOptions, NULL, &hKey, NULL));

		IfFailGo(RegSetValueEx(hKey, L"LoadBehavior", 0, REG_DWORD, (BYTE*)&dwStartupContext, sizeof(DWORD)));
		IfFailGo(RegSetValueEx(hKey, L"CommandLineSafe", 0, REG_DWORD, (BYTE*)&dwCommandLineSafe, sizeof(DWORD)));

		if (NULL != pszFriendlyName)
		{
#if UNICODE
			dwTemp = lstrlen(pszFriendlyName) * 2 + 2;
#else
			dwTemp = lstrlen(pszFriendlyName) + 1;
#endif
			IfFailGo(RegSetValueEx(hKey, L"FriendlyName", 0, REG_SZ, (BYTE*)pszFriendlyName, dwTemp));

#if UNICODE
			dwTemp = lstrlen(pszDescription) * 2 + 2;
#else
			dwTemp = lstrlen(pszDescription) + 1;
#endif
			IfFailGo(RegSetValueEx(hKey, L"Description", 0, REG_SZ, (BYTE*)pszDescription, dwTemp));
		}

		RegCloseKey(hKey);

		return hr;
	Error:
		if (keyCreated)
		{
			RegCloseKey(hKey);
			RegDeleteKey(hKey, szKeyBuf);
		}
		return hr;
	}

	HRESULT UnRegisterCOMAddin(LPCWSTR pszOfficeApp, LPCWSTR pszProgID, bool registerPerMachine)
	{
		HRESULT result = S_OK;

		HKEY root = registerPerMachine ? HKEY_LOCAL_MACHINE : HKEY_CURRENT_USER;
		WCHAR szKeyBuf[1024];
		lstrcpy(szKeyBuf, L"Software\\Microsoft\\Office\\");
		lstrcat(szKeyBuf, pszOfficeApp);
		lstrcat(szKeyBuf, L"\\Addins\\");
		lstrcat(szKeyBuf, pszProgID);

		HRESULT hr = RecursiveDeleteKey(root, szKeyBuf);
		if (E_ACCESSDENIED != hr) // if key is missing - we dont care
		{
			result = hr;
		}

		return result;
	}

	HKEY TargetRootKey(RegisterMode mode)
	{
		HKEY hKeyRoot = HKEY_CURRENT_USER;
		switch (mode)
		{
		case System:
		case SystemComponentAndUserAddin:
			hKeyRoot = HKEY_LOCAL_MACHINE;
			break;
		}
		return hKeyRoot;
	}

	void ClassIdSubKey(LPCWSTR classId, RegisterMode mode, WCHAR* classIdKey)
	{
		lstrcpy(classIdKey, L"Software\\Classes\\CLSID\\");
		lstrcat(classIdKey, classId);
	}

	void ProgIdSubKey(LPCWSTR progId, RegisterMode mode, WCHAR* progIdKey)
	{
		lstrcpy(progIdKey, L"Software\\Classes\\");
	}

	BOOL SetKeyAndValue(HKEY hKeyRoot, LPCWSTR pszPath, LPCWSTR pszSubkey1, LPCWSTR pszSubkey2, LPCWSTR pszvalueName, LPCWSTR pszValue)
	{
		HKEY hKey;
		WCHAR szKeyBuf[1024];

		lstrcpy(szKeyBuf, pszPath);

		if (pszSubkey1 != NULL)
		{
			lstrcat(szKeyBuf, L"\\");
			lstrcat(szKeyBuf, pszSubkey1);
		}
		if (pszSubkey2 != NULL)
		{
			lstrcat(szKeyBuf, L"\\");
			lstrcat(szKeyBuf, pszSubkey2);
		}

		// if its return 5 - E_ACCESS_DENIED
		long lResult = RegCreateKeyEx(hKeyRoot, szKeyBuf, 0, NULL, REG_OPTION_NON_VOLATILE, _regKeyOptions, NULL, &hKey, NULL);
		if (lResult != ERROR_SUCCESS)
			return FALSE;

		if (pszValue != NULL)
		{
#if UNICODE
			RegSetValueEx(hKey, pszvalueName, 0, REG_SZ, (BYTE*)pszValue, lstrlen(pszValue) * 2 + 2);
#else
			RegSetValueEx(hKey, pszvalueName, 0, REG_SZ, (BYTE*)pszValue, lstrlen(pszValue) + 1);
#endif
		}

		RegCloseKey(hKey);
		return TRUE;
	}

	LONG RecursiveDeleteKey(HKEY hKeyParent, LPCWSTR pszKeyChild)
	{
		HKEY hKeyChild;
		LONG lRes = RegOpenKeyEx(hKeyParent, pszKeyChild, 0, _regKeyOptions, &hKeyChild);
		if (lRes != ERROR_SUCCESS)
			return lRes;

		FILETIME time;
		WCHAR szBuffer[256];
		DWORD dwSize = 256;
		while (RegEnumKeyEx(hKeyChild, 0, szBuffer, &dwSize, NULL, NULL, NULL, &time) == S_OK)
		{
			lRes = RecursiveDeleteKey(hKeyChild, szBuffer);
			if (lRes != ERROR_SUCCESS)
			{
				RegCloseKey(hKeyChild);
				return lRes;
			}
			dwSize = 256;
		}

		RegCloseKey(hKeyChild);
		return RegDeleteKey(hKeyParent, pszKeyChild);
	}
}