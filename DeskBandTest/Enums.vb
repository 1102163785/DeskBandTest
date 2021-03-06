﻿Public Enum HResult As Integer
    S_OK = 0
    S_FALSE = 1

    E_UNEXPECTED = &H8000FFFF 'Catastrophic failure
    E_NOTIMPL = &H80004001 'Not implemented
    E_OUTOFMEMORY = &H8007000E 'Ran out Of memory
    E_INVALIDARG = &H80070057 'One Or more arguments are invalid
    E_NOINTERFACE = &H80004002 'No such Interface supported
    E_POINTER = &H80004003 'Invalid pointer
    E_HANDLE = &H80070006 'Invalid handle
    E_ABORT = &H80004004 'Operation aborted
    E_FAIL = &H80004005 'Unspecified error
    E_ACCESSDENIED = &H80070005 'General access denied Error
    E_PENDING = &H8000000A 'The data necessary To complete this operation Is Not yet available.
    E_BOUNDS = &H8000000B 'The operation attempted To access data outside the valid range
    E_CHANGED_STATE = &H8000000C 'A concurrent Or interleaved operation changed the state Of the Object, invalidating this operation.
    E_ILLEGAL_STATE_CHANGE = &H8000000D 'An illegal state change was requested.
    E_ILLEGAL_METHOD_CALL = &H8000000E 'A method was called at an unexpected time.
    RO_E_METADATA_NAME_NOT_FOUND = &H8000000F 'Typename Or Namespace was Not found in metadata file.
    RO_E_METADATA_NAME_IS_NAMESPACE = &H80000010 'Name Is an existing namespace rather than a typename.
    RO_E_METADATA_INVALID_TYPE_FORMAT = &H80000011 'Typename has an invalid format.
    RO_E_INVALID_METADATA_FILE = &H80000012 'Metadata file Is invalid Or corrupted.
    RO_E_CLOSED = &H80000013 'The Object has been closed.
    RO_E_EXCLUSIVE_WRITE = &H80000014 'Only one thread may access the Object during a write operation.
    RO_E_CHANGE_NOTIFICATION_IN_PROGRESS = &H80000015 'Operation Is prohibited during change notification.
    RO_E_ERROR_STRING_NOT_FOUND = &H80000016 'The text associated With this Error code could Not be found.
    E_STRING_NOT_NULL_TERMINATED = &H80000017 'String Not null terminated.
    E_ILLEGAL_DELEGATE_ASSIGNMENT = &H80000018 'A Delegate was assigned When Not allowed.
    E_ASYNC_OPERATION_NOT_STARTED = &H80000019 'An Async operation was Not properly started.
    E_APPLICATION_EXITING = &H8000001A 'The application Is exiting And cannot service this request.
    E_APPLICATION_VIEW_EXITING = &H8000001B 'The application view Is exiting And cannot service this request.
    RO_E_MUST_BE_AGILE = &H8000001C 'The Object must support the IAgileObject interface.
    RO_E_UNSUPPORTED_FROM_MTA = &H8000001D 'Activating a Single-threaded Class from MTA Is Not supported.
    RO_E_COMMITTED = &H8000001E 'The Object has been committed.
    CO_E_INIT_TLS = &H80004006 'Thread local storage failure
    CO_E_INIT_SHARED_ALLOCATOR = &H80004007 'Get Shared memory allocator failure
    CO_E_INIT_MEMORY_ALLOCATOR = &H80004008 'Get memory allocator failure
    CO_E_INIT_CLASS_CACHE = &H80004009 'Unable to initialize class cache
    CO_E_INIT_RPC_CHANNEL = &H8000400A 'Unable to initialize RPC services
    CO_E_INIT_TLS_SET_CHANNEL_CONTROL = &H8000400B 'Cannot set thread local storage channel control
    CO_E_INIT_TLS_CHANNEL_CONTROL = &H8000400C 'Could Not allocate thread local storage channel control
    CO_E_INIT_UNACCEPTED_USER_ALLOCATOR = &H8000400D 'The user supplied memory allocator Is unacceptable
    CO_E_INIT_SCM_MUTEX_EXISTS = &H8000400E 'The OLE service mutex already exists
    CO_E_INIT_SCM_FILE_MAPPING_EXISTS = &H8000400F 'The OLE service file mapping already exists
    CO_E_INIT_SCM_MAP_VIEW_OF_FILE = &H80004010 'Unable to map view of file for OLE service
    CO_E_INIT_SCM_EXEC_FAILURE = &H80004011 'Failure attempting To launch OLE service
    CO_E_INIT_ONLY_SINGLE_THREADED = &H80004012 'There was an attempt To Call CoInitialize a second time While Single threaded
    CO_E_CANT_REMOTE = &H80004013 'A Remote activation was necessary but was Not allowed
    CO_E_BAD_SERVER_NAME = &H80004014 'A Remote activation was necessary but the server name provided was invalid
    CO_E_WRONG_SERVER_IDENTITY = &H80004015 'The Class is configured To run As a security id different from the caller
    CO_E_OLE1DDE_DISABLED = &H80004016 'Use of Ole1 services requiring DDE windows Is disabled
    CO_E_RUNAS_SYNTAX = &H80004017 'A RunAs specification must be <domain name>\<user name> Or simply <user name>.
    CO_E_CREATEPROCESS_FAILURE = &H80004018 'The server process could Not be started. The pathname may be incorrect.
    CO_E_RUNAS_CREATEPROCESS_FAILURE = &H80004019 'The server process could Not be started As the configured identity. The pathname may be incorrect Or unavailable.
    CO_E_RUNAS_LOGON_FAILURE = &H8000401A 'The server process could Not be started because the configured identity Is incorrect. Check the user name And password.
    CO_E_LAUNCH_PERMSSION_DENIED = &H8000401B 'The client Is Not allowed To launch this server.
    CO_E_START_SERVICE_FAILURE = &H8000401C 'The service providing this server could Not be started.
    CO_E_REMOTE_COMMUNICATION_FAILURE = &H8000401D 'This computer was unable To communicate With the computer providing the server.
    CO_E_SERVER_START_TIMEOUT = &H8000401E 'The server did Not respond after being launched.
    CO_E_CLSREG_INCONSISTENT = &H8000401F 'The registration information For this server Is inconsistent Or incomplete.
    CO_E_IIDREG_INCONSISTENT = &H80004020 'The registration information For this Interface Is inconsistent Or incomplete.
    CO_E_NOT_SUPPORTED = &H80004021 'The operation attempted Is Not supported.
    CO_E_RELOAD_DLL = &H80004022 'A dll must be loaded.
    CO_E_MSI_ERROR = &H80004023 'A Microsoft Software Installer Error was encountered.
    CO_E_ATTEMPT_TO_CREATE_OUTSIDE_CLIENT_CONTEXT = &H80004024 'The specified activation could Not occur In the client context As specified.
    CO_E_SERVER_PAUSED = &H80004025 'Activations on the server are paused.
    CO_E_SERVER_NOT_PAUSED = &H80004026 'Activations on the server are Not paused.
    CO_E_CLASS_DISABLED = &H80004027 'The component Or application containing the component has been disabled.
    CO_E_CLRNOTAVAILABLE = &H80004028 'The common language runtime Is Not available
    CO_E_ASYNC_WORK_REJECTED = &H80004029 'The thread-pool rejected the submitted asynchronous work.
    CO_E_SERVER_INIT_TIMEOUT = &H8000402A 'The server started, but did Not finish initializing In a timely fashion.
    CO_E_NO_SECCTX_IN_ACTIVATE = &H8000402B 'Unable to complete the call since there Is no COM+ security context inside IObjectControl.Activate.
    CO_E_TRACKER_CONFIG = &H80004030 'The provided tracker configuration Is invalid
    CO_E_THREADPOOL_CONFIG = &H80004031 'The provided thread pool configuration Is invalid
    CO_E_SXS_CONFIG = &H80004032 'The provided side-by-side configuration Is invalid
    CO_E_MALFORMED_SPN = &H80004033 'The server principal name (SPN) obtained during security negotiation Is malformed.
    OLE_E_OLEVERB = &H80040000 'Invalid OLEVERB Structure
    OLE_E_ADVF = &H80040001 'Invalid advise flags
    OLE_E_ENUM_NOMORE = &H80040002 'Can't enumerate any more, because the associated data is missing
    OLE_E_ADVISENOTSUPPORTED = &H80040003 'This implementation doesn't take advises
    OLE_E_NOCONNECTION = &H80040004 'There Is no connection for this connection ID
    OLE_E_NOTRUNNING = &H80040005 'Need to run the object to perform this operation
    OLE_E_NOCACHE = &H80040006 'There Is no cache to operate on
    OLE_E_BLANK = &H80040007 'Uninitialized object
    OLE_E_CLASSDIFF = &H80040008 'Linked object's source class has changed
    OLE_E_CANT_GETMONIKER = &H80040009 'Not able to get the moniker of the object
    OLE_E_CANT_BINDTOSOURCE = &H8004000A 'Not able to bind to the source
    OLE_E_STATIC = &H8004000B 'Object Is static; operation Not allowed
    OLE_E_PROMPTSAVECANCELLED = &H8004000C 'User canceled out Of save dialog
    OLE_E_INVALIDRECT = &H8004000D 'Invalid rectangle
    OLE_E_WRONGCOMPOBJ = &H8004000E 'compobj.dll Is too old for the ole2.dll initialized
    OLE_E_INVALIDHWND = &H8004000F 'Invalid window handle
    OLE_E_NOT_INPLACEACTIVE = &H80040010 'Object Is Not in any of the inplace active states
    OLE_E_CANTCONVERT = &H80040011 'Not able to convert object
    OLE_E_NOSTORAGE = &H80040012 'Not able to perform the operation because object Is Not given storage yet
    DV_E_FORMATETC = &H80040064 'Invalid FORMATETC Structure
    DV_E_DVTARGETDEVICE = &H80040065 'Invalid DVTARGETDEVICE Structure
    DV_E_STGMEDIUM = &H80040066 'Invalid STDGMEDIUM Structure
    DV_E_STATDATA = &H80040067 'Invalid STATDATA Structure
    DV_E_LINDEX = &H80040068 'Invalid lindex
    DV_E_TYMED = &H80040069 'Invalid tymed
    DV_E_CLIPFORMAT = &H8004006A 'Invalid clipboard format
    DV_E_DVASPECT = &H8004006B 'Invalid aspect(s)
    DV_E_DVTARGETDEVICE_SIZE = &H8004006C 'tdSize parameter Of the DVTARGETDEVICE Structure Is invalid
    DV_E_NOIVIEWOBJECT = &H8004006D 'Object doesn't support IViewObject interface
    DRAGDROP_E_NOTREGISTERED = &H80040100 'Trying to revoke a drop target that has Not been registered
    DRAGDROP_E_ALREADYREGISTERED = &H80040101 'This window has already been registered As a drop target
    DRAGDROP_E_INVALIDHWND = &H80040102 'Invalid window handle
    CLASS_E_NOAGGREGATION = &H80040110 'Class does Not support aggregation (Or Class Object Is remote)
    CLASS_E_CLASSNOTAVAILABLE = &H80040111 'ClassFactory cannot supply requested Class
    CLASS_E_NOTLICENSED = &H80040112 'Class is Not licensed For use
    VIEW_E_DRAW = &H80040140 'Error drawing view
    REGDB_E_READREGDB = &H80040150 'Could Not read key from registry
    REGDB_E_WRITEREGDB = &H80040151 'Could Not write key to registry
    REGDB_E_KEYMISSING = &H80040152 'Could Not find the key in the registry
    REGDB_E_INVALIDVALUE = &H80040153 'Invalid value For registry
    REGDB_E_CLASSNOTREG = &H80040154 'Class not registered
    REGDB_E_IIDNOTREG = &H80040155 'Interface not registered
    REGDB_E_BADTHREADINGMODEL = &H80040156 'Threading model entry Is Not valid
    CAT_E_CATIDNOEXIST = &H80040160 'CATID does Not exist
    CAT_E_NODESCRIPTION = &H80040161 'Description Not found
    CS_E_PACKAGE_NOTFOUND = &H80040164 'No package In the software installation data In the Active Directory meets this criteria.
    CS_E_NOT_DELETABLE = &H80040165 'Deleting this will break the referential integrity Of the software installation data In the Active Directory.
    CS_E_CLASS_NOTFOUND = &H80040166 'The CLSID was Not found In the software installation data In the Active Directory.
    CS_E_INVALID_VERSION = &H80040167 'The software installation data In the Active Directory Is corrupt.
    CS_E_NO_CLASSSTORE = &H80040168 'There Is no software installation data in the Active Directory.
    CS_E_OBJECT_NOTFOUND = &H80040169 'There Is no software installation data object in the Active Directory.
    CS_E_OBJECT_ALREADY_EXISTS = &H8004016A 'The software installation data Object In the Active Directory already exists.
    CS_E_INVALID_PATH = &H8004016B 'The path To the software installation data In the Active Directory Is Not correct.
    CS_E_NETWORK_ERROR = &H8004016C 'A network Error interrupted the operation.
    CS_E_ADMIN_LIMIT_EXCEEDED = &H8004016D 'The size Of this Object exceeds the maximum size Set by the Administrator.
    CS_E_SCHEMA_MISMATCH = &H8004016E 'The schema For the software installation data In the Active Directory does Not match the required schema.
    CS_E_INTERNAL_ERROR = &H8004016F 'An error occurred in the software installation data in the Active Directory.
    CACHE_E_NOCACHE_UPDATED = &H80040170 'Cache Not updated
    OLEOBJ_E_NOVERBS = &H80040180 'No verbs For OLE Object
    OLEOBJ_E_INVALIDVERB = &H80040181 'Invalid verb For OLE Object
    INPLACE_E_NOTUNDOABLE = &H800401A0 'Undo Is Not available
    INPLACE_E_NOTOOLSPACE = &H800401A1 'Space for tools Is Not available
    CONVERT10_E_OLESTREAM_GET = &H800401C0 'OLESTREAM Get method failed
    CONVERT10_E_OLESTREAM_PUT = &H800401C1 'OLESTREAM Put method failed
    CONVERT10_E_OLESTREAM_FMT = &H800401C2 'Contents of the OLESTREAM Not in correct format
    CONVERT10_E_OLESTREAM_BITMAP_TO_DIB = &H800401C3 'There was an Error In a Windows GDI Call While converting the bitmap To a DIB
    CONVERT10_E_STG_FMT = &H800401C4 'Contents of the IStorage Not in correct format
    CONVERT10_E_STG_NO_STD_STREAM = &H800401C5 'Contents of IStorage Is missing one of the standard streams
    CONVERT10_E_STG_DIB_TO_BITMAP = &H800401C6 'There was an Error In a Windows GDI Call While converting the DIB To a bitmap.
    CLIPBRD_E_CANT_OPEN = &H800401D0 'OpenClipboard Failed
    CLIPBRD_E_CANT_EMPTY = &H800401D1 'EmptyClipboard Failed
    CLIPBRD_E_CANT_SET = &H800401D2 'SetClipboard Failed
    CLIPBRD_E_BAD_DATA = &H800401D3 'Data on clipboard Is invalid
    CLIPBRD_E_CANT_CLOSE = &H800401D4 'CloseClipboard Failed
    MK_E_CONNECTMANUALLY = &H800401E0 'Moniker needs To be connected manually
    MK_E_EXCEEDEDDEADLINE = &H800401E1 'Operation exceeded deadline
    MK_E_NEEDGENERIC = &H800401E2 'Moniker needs To be generic
    MK_E_UNAVAILABLE = &H800401E3 'Operation unavailable
    MK_E_SYNTAX = &H800401E4 'Invalid syntax
    MK_E_NOOBJECT = &H800401E5 'No object for moniker
    MK_E_INVALIDEXTENSION = &H800401E6 'Bad extension For file
    MK_E_INTERMEDIATEINTERFACENOTSUPPORTED = &H800401E7 'Intermediate operation failed
    MK_E_NOTBINDABLE = &H800401E8 'Moniker Is Not bindable
    MK_E_NOTBOUND = &H800401E9 'Moniker Is Not bound
    MK_E_CANTOPENFILE = &H800401EA 'Moniker cannot open file
    MK_E_MUSTBOTHERUSER = &H800401EB 'User input required For operation To succeed
    MK_E_NOINVERSE = &H800401EC 'Moniker Class has no inverse
    MK_E_NOSTORAGE = &H800401ED 'Moniker does Not refer To storage
    MK_E_NOPREFIX = &H800401EE 'No common prefix
    MK_E_ENUMERATION_FAILED = &H800401EF 'Moniker could Not be enumerated
    CO_E_NOTINITIALIZED = &H800401F0 'CoInitialize has Not been called.
    CO_E_ALREADYINITIALIZED = &H800401F1 'CoInitialize has already been called.
    CO_E_CANTDETERMINECLASS = &H800401F2 'Class of Object cannot be determined
    CO_E_CLASSSTRING = &H800401F3 'Invalid Class string
    CO_E_IIDSTRING = &H800401F4 'Invalid Interface string
    CO_E_APPNOTFOUND = &H800401F5 'Application Not found
    CO_E_APPSINGLEUSE = &H800401F6 'Application cannot be run more than once
    CO_E_ERRORINAPP = &H800401F7 'Some error in application program
    CO_E_DLLNOTFOUND = &H800401F8 'DLL for class Not found
    CO_E_ERRORINDLL = &H800401F9 'Error in the DLL
    CO_E_WRONGOSFORAPP = &H800401FA 'Wrong operating system Or operating system version For the application
    CO_E_OBJNOTREG = &H800401FB 'Object Is Not registered
    CO_E_OBJISREG = &H800401FC 'Object Is already registered
    CO_E_OBJNOTCONNECTED = &H800401FD 'Object Is Not connected to server
    CO_E_APPDIDNTREG = &H800401FE 'Application was launched but it didn't register a class factory
    CO_E_RELEASED = &H800401FF 'Object has been released
    EVENT_S_SOME_SUBSCRIBERS_FAILED = &H40200 'An Event was able To invoke some but Not all Of the subscribers
    EVENT_E_ALL_SUBSCRIBERS_FAILED = &H80040201 'An Event was unable To invoke any Of the subscribers
    EVENT_S_NOSUBSCRIBERS = &H40202 'An Event was delivered but there were no subscribers
    EVENT_E_QUERYSYNTAX = &H80040203 'A syntax Error occurred trying To evaluate a query String
    EVENT_E_QUERYFIELD = &H80040204 'An invalid field name was used In a query String
    EVENT_E_INTERNALEXCEPTION = &H80040205 'An unexpected exception was raised
    EVENT_E_INTERNALERROR = &H80040206 'An unexpected internal Error was detected
    EVENT_E_INVALID_PER_USER_SID = &H80040207 'The owner SID On a per-user subscription doesn't exist
    EVENT_E_USER_EXCEPTION = &H80040208 'A user-supplied component Or subscriber raised an exception
    EVENT_E_TOO_MANY_METHODS = &H80040209 'An Interface has too many methods To fire events from
    EVENT_E_MISSING_EVENTCLASS = &H8004020A 'A subscription cannot be stored unless its Event Class already exists
    EVENT_E_NOT_ALL_REMOVED = &H8004020B 'Not all the objects requested could be removed
    EVENT_E_COMPLUS_NOT_INSTALLED = &H8004020C 'COM+ Is required for this operation, but Is Not installed
    EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT = &H8004020D 'Cannot modify Or delete an Object that was Not added Using the COM+ Admin SDK
    EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT = &H8004020E 'Cannot modify Or delete an Object that was added Using the COM+ Admin SDK
    EVENT_E_INVALID_EVENT_CLASS_PARTITION = &H8004020F 'The Event class For this subscription Is In an invalid partition
    EVENT_E_PER_USER_SID_NOT_LOGGED_ON = &H80040210 'The owner Of the PerUser subscription Is Not logged On To the system specified
End Enum


<Flags>
Public Enum DBIM As UInteger
    MINSIZE = &H1
    MAXSIZE = &H2
    INTEGRAL = &H4
    ACTUAL = &H8
    TITLE = &H10
    MODEFLAGS = &H20
    BKCOLOR = &H40


End Enum

Public Enum HMONITOR_OPTION As UInteger
    MONITOR_DEFAULTTONULL
    MONITOR_DEFAULTTOPRIMARY
    MONITOR_DEFAULTTONEAREST
End Enum

<Flags>
Public Enum DBIMF
    NORMAL = &H0
    FIXED = &H1
    FIXEDBMP = &H4   ' a fixed background bitmap (If supported)
    VARIABLEHEIGHT = &H8
    UNDELETEABLE = &H10
    DEBOSSED = &H20
    BKCOLOR = &H40
    USECHEVRON = &H80
    BREAK = &H100
    ADDTOFRONT = &H200
    TOPALIGN = &H400
#If NTDDI_VERSION >= NTDDI_VISTA Then
    NOGRIPPER = &H800
    ALWAYSGRIPPER = &H1000
    NOMARGINS = &H2000
#End If  ' NTDDI_VISTA
End Enum

Public Enum DBIF
    VIEWMODE_NORMAL = &H0
    VIEWMODE_VERTICAL = &H1
    VIEWMODE_FLOATING = &H2
    VIEWMODE_TRANSPARENT = &H4
End Enum