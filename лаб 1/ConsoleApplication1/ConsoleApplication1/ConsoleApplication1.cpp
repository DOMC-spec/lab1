#include <windows.h>
#include <iostream>
#include <string>
#include <ctime>


int main() {
    setlocale(LC_ALL, "Russian");
    // 1. Время работы ОС
    ULONGLONG ticks = GetTickCount64(); // миллисекунды с запуска
    ULONGLONG seconds = ticks / 1000;
    int days = seconds / (24 * 3600);
    seconds %= (24 * 3600);
    int hours = seconds / 3600;
    seconds %= 3600;
    int minutes = seconds / 60;
    seconds %= 60;

    std::cout << "Время работы ОС: "
        << days << " дн., "
        << hours << " ч., "
        << minutes << " мин., "
        << seconds << " сек." << std::endl;

    // 2. MessageBox с текущим временем
    SYSTEMTIME st;
    GetLocalTime(&st); // текущее локальное время

    wchar_t buffer[100];
    swprintf(buffer, 100, L"Дата: %02d.%02d.%04d\nВремя: %02d:%02d:%02d",
        st.wDay, st.wMonth, st.wYear,
        st.wHour, st.wMinute, st.wSecond);

    MessageBoxW(NULL, buffer, L"Текущее время и дата", MB_OK | MB_ICONINFORMATION);

    // 3. Имя компьютера и пользователя
    wchar_t compName[MAX_COMPUTERNAME_LENGTH + 1];
    DWORD compSize = MAX_COMPUTERNAME_LENGTH + 1;
    GetComputerNameW(compName, &compSize);

    const DWORD UNLEN = 256;

    wchar_t userName[UNLEN + 1];
    DWORD userSize = UNLEN + 1;
    GetUserNameW(userName, &userSize);

    std::wcout << L"Имя компьютера: " << compName << std::endl;
    std::wcout << L"Имя пользователя: " << userName << std::endl;

    return 0;
}