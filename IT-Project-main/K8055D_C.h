/*****************************************************************
******************************************************************
** Microsoft Visual C++ 2005 Project for the K8055 USB I/O Card **
**                                                              **
**                    Copyright Velleman 2006                   **
**                        www.Velleman.be                       **
**                                                              **
**                                                              **
**                                                              **
**                         Developed by                         **
**                       RE-Applications                        **
**                   www.RE-Applications.be                     **
******************************************************************
******************************************************************/
#ifdef __cplusplus
extern "C" {
#endif

#define FUNCTION __declspec(dllexport)
//#define FUNCTION
#define VOID void

FUNCTION long __stdcall OpenDevice(long CardAddress);
VOID __stdcall CloseDevice();
FUNCTION long __stdcall ReadAnalogChannel(long Channel);
VOID __stdcall ReadAllAnalog(long *Data1, long *Data2);
VOID __stdcall OutputAnalogChannel(long Channel, long Data);
VOID __stdcall OutputAllAnalog(long Data1, long Data2);
VOID __stdcall ClearAnalogChannel(long Channel);
VOID __stdcall ClearAllAnalog();
VOID __stdcall SetAnalogChannel(long Channel);
VOID __stdcall SetAllAnalog();
VOID __stdcall WriteAllDigital(long Data);
VOID __stdcall ClearDigitalChannel(long Channel);
VOID __stdcall ClearAllDigital();
VOID __stdcall SetDigitalChannel(long Channel);
VOID __stdcall SetAllDigital();
FUNCTION /*bool*/ __stdcall ReadDigitalChannel(long Channel);
FUNCTION long __stdcall ReadAllDigital();
FUNCTION long __stdcall ReadCounter(long CounterNr);
VOID __stdcall ResetCounter(long CounterNr);
VOID __stdcall SetCounterDebounceTime(long CounterNr, long DebounceTime);

VOID __stdcall Version();
FUNCTION long __stdcall SearchDevices();
FUNCTION long __stdcall SetCurrentDevice(long lngCardAddress);

#ifdef __cplusplus
}
#endif



