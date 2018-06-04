using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_ROOM_INFORMATION_HELPER_V1
{
    public class UserModuleClass_ROOM_INFORMATION_HELPER_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput UPDATE_ROOM_INFO_B;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_INFO_SAVE_B;
        Crestron.Logos.SplusObjects.StringInput ROOMNAME_SAVE;
        Crestron.Logos.SplusObjects.StringInput ROOMNUMBER_SAVE;
        Crestron.Logos.SplusObjects.StringInput ROOMIP_SAVE;
        Crestron.Logos.SplusObjects.StringInput ROOMADDITIONAL_SAVE;
        Crestron.Logos.SplusObjects.StringInput FILENAME;
        Crestron.Logos.SplusObjects.StringInput FILELOCATION;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_INFO_UPDATE_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_INFO_SAVE_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_INFO_SAVE_COMPLETE_PULSE;
        Crestron.Logos.SplusObjects.StringOutput ROOM_NAME;
        Crestron.Logos.SplusObjects.StringOutput ROOM_NUMBER;
        Crestron.Logos.SplusObjects.StringOutput ROOM_IP;
        Crestron.Logos.SplusObjects.StringOutput ROOM_ADDITIONAL;
        UShortParameter DEBUGMODE;
        ushort G_DEBUG = 0;
        ushort G_FILE_RESULT = 0;
        ushort G_PARSE_RESULT = 0;
        ushort G_FILE_OK = 0;
        ushort G_COUNT = 0;
        ushort G_FILE_LOCATION_TYPE = 0;
        ushort G_DATA_TYPE = 0;
        CrestronString G_FILENAME;
        CrestronString G_FILELOCATION;
        CrestronString G_TOTALFILE;
        CrestronString G_STEMP;
        CrestronString G_ROOMNAME_TXT;
        CrestronString G_ROOMNUMBER_TXT;
        CrestronString G_ROOMIP_TXT;
        CrestronString G_ROOMADDITIONAL_TXT;
        private void READFILELOCAL (  SplusExecutionContext __context__ ) 
            { 
            ushort FILEREADOK = 0;
            
            short NFILEHANDLE = 0;
            short NNUMREAD = 0;
            
            
            __context__.SourceCodeLine = 45;
            FILEREADOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 47;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 52;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FILE_LOCATION_TYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 54;
                if ( Functions.TestForTrue  ( ( CheckForNVRAMDisk())  ) ) 
                    { 
                    __context__.SourceCodeLine = 56;
                    FILEREADOK = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 57;
                    if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 57;
                        Print( "NVRAM Disk Ok\r\n") ; 
                        }
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 61;
                    FILEREADOK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 62;
                    if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 62;
                        Print( "NVRAM Disk Missing\r\n") ; 
                        }
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 67;
                if ( Functions.TestForTrue  ( ( CheckForDisk())  ) ) 
                    { 
                    __context__.SourceCodeLine = 69;
                    FILEREADOK = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 70;
                    if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 70;
                        Print( "Compact Flash Ok\r\n") ; 
                        }
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 74;
                    FILEREADOK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 75;
                    if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 75;
                        Print( "Compact Flash Missing\r\n") ; 
                        }
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 79;
            if ( Functions.TestForTrue  ( ( FILEREADOK)  ) ) 
                { 
                __context__.SourceCodeLine = 81;
                if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 81;
                    Print( "g_TotalFile = {0}\r\n", G_TOTALFILE ) ; 
                    }
                
                __context__.SourceCodeLine = 83;
                if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                    { 
                    __context__.SourceCodeLine = 85;
                    NFILEHANDLE = (short) ( FileOpen( "\\NVRAM\\RoomInfo.ini" ,(ushort) (0 | 16384) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 89;
                    NFILEHANDLE = (short) ( FileOpen( G_TOTALFILE ,(ushort) (0 | 16384) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 92;
                if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                    { 
                    __context__.SourceCodeLine = 94;
                    Print( "FileOpen Complete\r\n") ; 
                    __context__.SourceCodeLine = 95;
                    Print( "nFileHandle = {0:d}\r\n", (ushort)NFILEHANDLE) ; 
                    } 
                
                __context__.SourceCodeLine = 98;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 100;
                    NNUMREAD = (short) ( FileRead( (short)( NFILEHANDLE ) , G_STEMP , (ushort)( 20000 ) ) ) ; 
                    __context__.SourceCodeLine = 102;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NNUMREAD < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 104;
                        if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 104;
                            Print( "File Read Error\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 105;
                        G_FILE_RESULT = (ushort) ( 2 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 109;
                        G_FILE_RESULT = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 111;
                    FileClose (  (short) ( NFILEHANDLE ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 115;
                    if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                        { 
                        __context__.SourceCodeLine = 117;
                        Print( "nFileHandle Error\r\n") ; 
                        __context__.SourceCodeLine = 118;
                        Print( "g_TotalFile = {0}\r\n", G_TOTALFILE ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 120;
                    G_FILE_RESULT = (ushort) ( 2 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 125;
                G_FILE_RESULT = (ushort) ( 2 ) ; 
                __context__.SourceCodeLine = 126;
                if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 126;
                    Print( "No Compact Flash or NVRAM disk exsists\r\n") ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 128;
            EndFileOperations ( ) ; 
            
            }
            
        private ushort DATATYPE (  SplusExecutionContext __context__, CrestronString TESTDATA ) 
            { 
            
            __context__.SourceCodeLine = 133;
            if ( Functions.TestForTrue  ( ( Functions.Find( "RoomName" , TESTDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 135;
                G_DATA_TYPE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 136;
                return (ushort)( 1) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 138;
                if ( Functions.TestForTrue  ( ( Functions.Find( "RoomNumber" , TESTDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 140;
                    G_DATA_TYPE = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 141;
                    return (ushort)( 2) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 143;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "RoomIP" , TESTDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 145;
                        G_DATA_TYPE = (ushort) ( 3 ) ; 
                        __context__.SourceCodeLine = 146;
                        return (ushort)( 3) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 148;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "RoomAdditionalInfo" , TESTDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 150;
                            G_DATA_TYPE = (ushort) ( 4 ) ; 
                            __context__.SourceCodeLine = 151;
                            return (ushort)( 4) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 155;
                            G_DATA_TYPE = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 156;
                            return (ushort)( 0) ; 
                            } 
                        
                        }
                    
                    }
                
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void PARSEDATA (  SplusExecutionContext __context__ ) 
            { 
            ushort STARTOFDATA = 0;
            ushort ENDOFDATA = 0;
            ushort DATATYPEVAL = 0;
            
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 165;
            STARTOFDATA = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 166;
            ENDOFDATA = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 168;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_STEMP != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 170;
                STEMP  .UpdateValue ( Functions.Remove ( "\r\n" , G_STEMP )  ) ; 
                __context__.SourceCodeLine = 172;
                STARTOFDATA = (ushort) ( (Functions.Find( "=" , STEMP ) + 1) ) ; 
                __context__.SourceCodeLine = 173;
                ENDOFDATA = (ushort) ( Functions.Find( "\r\n" , STEMP , STARTOFDATA ) ) ; 
                __context__.SourceCodeLine = 175;
                DATATYPEVAL = (ushort) ( DATATYPE( __context__ , STEMP ) ) ; 
                __context__.SourceCodeLine = 176;
                CreateWait ( "__SPLS_TMPVAR__WAITLABEL_0__" , 50 , __SPLS_TMPVAR__WAITLABEL_0___Callback ) ;
                __context__.SourceCodeLine = 178;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DATATYPEVAL == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 180;
                    G_ROOMNAME_TXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( STARTOFDATA ) ,  (int) ( (ENDOFDATA - STARTOFDATA) ) )  ) ; 
                    __context__.SourceCodeLine = 181;
                    ROOM_NAME  .UpdateValue ( G_ROOMNAME_TXT  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 183;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DATATYPEVAL == 2))  ) ) 
                        { 
                        __context__.SourceCodeLine = 185;
                        G_ROOMNUMBER_TXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( STARTOFDATA ) ,  (int) ( (ENDOFDATA - STARTOFDATA) ) )  ) ; 
                        __context__.SourceCodeLine = 186;
                        ROOM_NUMBER  .UpdateValue ( G_ROOMNUMBER_TXT  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 188;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DATATYPEVAL == 3))  ) ) 
                            { 
                            __context__.SourceCodeLine = 190;
                            G_ROOMIP_TXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( STARTOFDATA ) ,  (int) ( (ENDOFDATA - STARTOFDATA) ) )  ) ; 
                            __context__.SourceCodeLine = 191;
                            ROOM_IP  .UpdateValue ( G_ROOMIP_TXT  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 193;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DATATYPEVAL == 4))  ) ) 
                                { 
                                __context__.SourceCodeLine = 195;
                                G_ROOMADDITIONAL_TXT  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( STARTOFDATA ) ,  (int) ( (ENDOFDATA - STARTOFDATA) ) )  ) ; 
                                __context__.SourceCodeLine = 196;
                                ROOM_ADDITIONAL  .UpdateValue ( G_ROOMADDITIONAL_TXT  ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 168;
                } 
            
            __context__.SourceCodeLine = 199;
            G_PARSE_RESULT = (ushort) ( 1 ) ; 
            
            }
            
        public void __SPLS_TMPVAR__WAITLABEL_0___CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            {
            __context__.SourceCodeLine = 176;
            ; 
            }
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void READROOMINFO (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 204;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOM_INFO_UPDATE_BUSY_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 206;
            ROOM_INFO_UPDATE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 208;
            G_FILE_RESULT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 209;
            G_PARSE_RESULT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 211;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 211;
                Print( "Start List Update\r\n") ; 
                }
            
            __context__.SourceCodeLine = 213;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_1__" , 100 , __SPLS_TMPVAR__WAITLABEL_1___Callback ) ;
            __context__.SourceCodeLine = 217;
            READFILELOCAL (  __context__  ) ; 
            __context__.SourceCodeLine = 219;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FILE_RESULT == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 221;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 219;
                } 
            
            __context__.SourceCodeLine = 224;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 224;
                Print( "ReadFile Finished\r\n") ; 
                }
            
            __context__.SourceCodeLine = 226;
            PARSEDATA (  __context__  ) ; 
            __context__.SourceCodeLine = 228;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_PARSE_RESULT == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 230;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 228;
                } 
            
            __context__.SourceCodeLine = 233;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 233;
                Print( "ParseData Finished\r\n") ; 
                }
            
            __context__.SourceCodeLine = 235;
            ROOM_INFO_UPDATE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 237;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 237;
                Print( "Update List Finished\r\n") ; 
                }
            
            } 
        
        
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_1___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            {
            __context__.SourceCodeLine = 215;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 215;
                Print( "Update List: Call ReadFileLocal\r\n") ; 
                }
            
            }
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
private void SAVEROOMINFO (  SplusExecutionContext __context__, CrestronString NEWNAME , CrestronString NEWNUMBER , CrestronString NEWIP , CrestronString NEWADDITIONALINFO ) 
    { 
    ushort X = 0;
    ushort FILELEN = 0;
    ushort FILEWRITEOK = 0;
    
    short NFILEHANDLE = 0;
    short NNUMWRITE = 0;
    
    CrestronString FILETEMP;
    FILETEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    
    __context__.SourceCodeLine = 247;
    FILETEMP  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 248;
    FILEWRITEOK = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 250;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FILE_LOCATION_TYPE == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 252;
        if ( Functions.TestForTrue  ( ( CheckForNVRAMDisk())  ) ) 
            { 
            __context__.SourceCodeLine = 254;
            FILEWRITEOK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 255;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 255;
                Print( "NVRAM Disk Ok\r\n") ; 
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 259;
            FILEWRITEOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 260;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 260;
                Print( "NVRAM Disk Missing\r\n") ; 
                }
            
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 265;
        if ( Functions.TestForTrue  ( ( CheckForDisk())  ) ) 
            { 
            __context__.SourceCodeLine = 267;
            FILEWRITEOK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 268;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 268;
                Print( "Compact Flash Ok\r\n") ; 
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 272;
            FILEWRITEOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 273;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 273;
                Print( "Compact Flash Missing\r\n") ; 
                }
            
            } 
        
        } 
    
    __context__.SourceCodeLine = 277;
    StartFileOperations ( ) ; 
    __context__.SourceCodeLine = 279;
    if ( Functions.TestForTrue  ( ( FILEWRITEOK)  ) ) 
        { 
        __context__.SourceCodeLine = 282;
        if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 282;
            Print( "Compact Flash or NVRAM Disk Ok\r\n") ; 
            }
        
        __context__.SourceCodeLine = 284;
        if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
            { 
            __context__.SourceCodeLine = 286;
            NFILEHANDLE = (short) ( FileOpen( "\\NVRAM\\RoomInfo.ini" ,(ushort) (((1 | 256) | 512) | 16384) ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 290;
            NFILEHANDLE = (short) ( FileOpen( G_TOTALFILE ,(ushort) (((1 | 256) | 512) | 16384) ) ) ; 
            } 
        
        __context__.SourceCodeLine = 293;
        if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
            { 
            __context__.SourceCodeLine = 295;
            Print( "FileOpen Complete\r\n") ; 
            __context__.SourceCodeLine = 296;
            Print( "nFileHandle = {0:d}\r\n", (ushort)NFILEHANDLE) ; 
            } 
        
        __context__.SourceCodeLine = 299;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 301;
            MakeString ( FILETEMP , "RoomName={0}\r\n", NEWNAME ) ; 
            __context__.SourceCodeLine = 302;
            MakeString ( FILETEMP , "{0}RoomNumber={1}\r\n", FILETEMP , NEWNUMBER ) ; 
            __context__.SourceCodeLine = 303;
            MakeString ( FILETEMP , "{0}RoomIP={1}\r\n", FILETEMP , NEWIP ) ; 
            __context__.SourceCodeLine = 304;
            MakeString ( FILETEMP , "{0}RoomAdditionalInfo={1}\r\n", FILETEMP , NEWADDITIONALINFO ) ; 
            __context__.SourceCodeLine = 306;
            FILELEN = (ushort) ( Functions.Length( FILETEMP ) ) ; 
            __context__.SourceCodeLine = 308;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 308;
                Print( "FileTemp = {0}\r\n", FILETEMP ) ; 
                }
            
            __context__.SourceCodeLine = 309;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 309;
                Print( "FileLen = {0:d}\r\n", (ushort)FILELEN) ; 
                }
            
            __context__.SourceCodeLine = 311;
            NNUMWRITE = (short) ( FileWrite( (short)( NFILEHANDLE ) , FILETEMP , (ushort)( FILELEN ) ) ) ; 
            __context__.SourceCodeLine = 312;
            FileClose (  (short) ( NFILEHANDLE ) ) ; 
            __context__.SourceCodeLine = 314;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( G_DEBUG ) && Functions.TestForTrue ( Functions.BoolToInt ( NNUMWRITE < 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 314;
                Print( "Error Writing to File\r\n") ; 
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 318;
            if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 318;
                Print( "nFileHandle Error\r\n") ; 
                }
            
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 323;
        if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
            { 
            __context__.SourceCodeLine = 325;
            Print( "No Compact Flash or NVRAM disk exsists\r\n") ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 328;
    EndFileOperations ( ) ; 
    __context__.SourceCodeLine = 330;
    Functions.Pulse ( 10, ROOM_INFO_SAVE_COMPLETE_PULSE ) ; 
    __context__.SourceCodeLine = 331;
    ROOM_INFO_SAVE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 332;
    READROOMINFO (  __context__  ) ; 
    
    }
    
object FILENAME_OnChange_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 340;
        G_FILENAME  .UpdateValue ( FILENAME  ) ; 
        __context__.SourceCodeLine = 341;
        G_TOTALFILE  .UpdateValue ( G_FILELOCATION + G_FILENAME  ) ; 
        __context__.SourceCodeLine = 343;
        G_FILE_OK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 345;
        if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
            { 
            __context__.SourceCodeLine = 347;
            Print( "g_FileName = {0}\r\n", G_FILENAME ) ; 
            __context__.SourceCodeLine = 348;
            Print( "g_TotalFile = {0}\r\n", G_TOTALFILE ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FILELOCATION_OnChange_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 354;
        G_FILELOCATION  .UpdateValue ( FILELOCATION  ) ; 
        __context__.SourceCodeLine = 356;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FILELOCATION == "\\CF0\\"))  ) ) 
            { 
            __context__.SourceCodeLine = 358;
            G_FILE_LOCATION_TYPE = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 362;
            G_FILE_LOCATION_TYPE = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 365;
        if ( Functions.TestForTrue  ( ( G_DEBUG)  ) ) 
            { 
            __context__.SourceCodeLine = 367;
            Print( "g_FileLocation = {0}\r\n", G_FILELOCATION ) ; 
            __context__.SourceCodeLine = 368;
            Print( "g_TotalFile = {0}\r\n", G_TOTALFILE ) ; 
            __context__.SourceCodeLine = 369;
            Print( "g_File_Location_Type = {0:d}\r\n", (ushort)G_FILE_LOCATION_TYPE) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UPDATE_ROOM_INFO_B_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 375;
        READROOMINFO (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_INFO_SAVE_B_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 380;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ROOM_INFO_UPDATE_BUSY_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 382;
            ROOM_INFO_SAVE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 383;
            SAVEROOMINFO (  __context__ , G_ROOMNAME_TXT, G_ROOMNUMBER_TXT, G_ROOMIP_TXT, G_ROOMADDITIONAL_TXT) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMNAME_SAVE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 389;
        G_ROOMNAME_TXT  .UpdateValue ( ROOMNAME_SAVE  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMNUMBER_SAVE_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 394;
        G_ROOMNUMBER_TXT  .UpdateValue ( ROOMNUMBER_SAVE  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMIP_SAVE_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 399;
        G_ROOMIP_TXT  .UpdateValue ( ROOMIP_SAVE  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOMADDITIONAL_SAVE_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 404;
        G_ROOMADDITIONAL_TXT  .UpdateValue ( ROOMADDITIONAL_SAVE  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 411;
        G_DEBUG = (ushort) ( DEBUGMODE  .Value ) ; 
        __context__.SourceCodeLine = 412;
        G_FILE_RESULT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 413;
        G_PARSE_RESULT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 414;
        G_FILE_OK = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 415;
        G_COUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 416;
        G_DATA_TYPE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 417;
        G_ROOMNAME_TXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 418;
        G_ROOMNUMBER_TXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 419;
        G_ROOMIP_TXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 420;
        G_ROOMADDITIONAL_TXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 422;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FILE_OK == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 425;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_2__" , 100 , __SPLS_TMPVAR__WAITLABEL_2___Callback ) ;
            __context__.SourceCodeLine = 430;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_COUNT == 10))  ) ) 
                { 
                __context__.SourceCodeLine = 432;
                G_FILE_OK = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 435;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 422;
            } 
        
        __context__.SourceCodeLine = 438;
        READFILELOCAL (  __context__  ) ; 
        __context__.SourceCodeLine = 440;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_FILE_RESULT == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 442;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 440;
            } 
        
        __context__.SourceCodeLine = 445;
        PARSEDATA (  __context__  ) ; 
        __context__.SourceCodeLine = 447;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_PARSE_RESULT == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 449;
            Functions.ProcessLogic ( ) ; 
            __context__.SourceCodeLine = 447;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    
public void __SPLS_TMPVAR__WAITLABEL_2___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 427;
            G_COUNT = (ushort) ( (G_COUNT + 1) ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_FILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    G_FILELOCATION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    G_TOTALFILE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 160, this );
    G_STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 600, this );
    G_ROOMNAME_TXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    G_ROOMNUMBER_TXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    G_ROOMIP_TXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 60, this );
    G_ROOMADDITIONAL_TXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 120, this );
    
    UPDATE_ROOM_INFO_B = new Crestron.Logos.SplusObjects.DigitalInput( UPDATE_ROOM_INFO_B__DigitalInput__, this );
    m_DigitalInputList.Add( UPDATE_ROOM_INFO_B__DigitalInput__, UPDATE_ROOM_INFO_B );
    
    ROOM_INFO_SAVE_B = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_INFO_SAVE_B__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_INFO_SAVE_B__DigitalInput__, ROOM_INFO_SAVE_B );
    
    ROOM_INFO_UPDATE_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_INFO_UPDATE_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_INFO_UPDATE_BUSY_FB__DigitalOutput__, ROOM_INFO_UPDATE_BUSY_FB );
    
    ROOM_INFO_SAVE_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_INFO_SAVE_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_INFO_SAVE_BUSY_FB__DigitalOutput__, ROOM_INFO_SAVE_BUSY_FB );
    
    ROOM_INFO_SAVE_COMPLETE_PULSE = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_INFO_SAVE_COMPLETE_PULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_INFO_SAVE_COMPLETE_PULSE__DigitalOutput__, ROOM_INFO_SAVE_COMPLETE_PULSE );
    
    ROOMNAME_SAVE = new Crestron.Logos.SplusObjects.StringInput( ROOMNAME_SAVE__AnalogSerialInput__, 60, this );
    m_StringInputList.Add( ROOMNAME_SAVE__AnalogSerialInput__, ROOMNAME_SAVE );
    
    ROOMNUMBER_SAVE = new Crestron.Logos.SplusObjects.StringInput( ROOMNUMBER_SAVE__AnalogSerialInput__, 60, this );
    m_StringInputList.Add( ROOMNUMBER_SAVE__AnalogSerialInput__, ROOMNUMBER_SAVE );
    
    ROOMIP_SAVE = new Crestron.Logos.SplusObjects.StringInput( ROOMIP_SAVE__AnalogSerialInput__, 60, this );
    m_StringInputList.Add( ROOMIP_SAVE__AnalogSerialInput__, ROOMIP_SAVE );
    
    ROOMADDITIONAL_SAVE = new Crestron.Logos.SplusObjects.StringInput( ROOMADDITIONAL_SAVE__AnalogSerialInput__, 120, this );
    m_StringInputList.Add( ROOMADDITIONAL_SAVE__AnalogSerialInput__, ROOMADDITIONAL_SAVE );
    
    FILENAME = new Crestron.Logos.SplusObjects.StringInput( FILENAME__AnalogSerialInput__, 60, this );
    m_StringInputList.Add( FILENAME__AnalogSerialInput__, FILENAME );
    
    FILELOCATION = new Crestron.Logos.SplusObjects.StringInput( FILELOCATION__AnalogSerialInput__, 60, this );
    m_StringInputList.Add( FILELOCATION__AnalogSerialInput__, FILELOCATION );
    
    ROOM_NAME = new Crestron.Logos.SplusObjects.StringOutput( ROOM_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOM_NAME__AnalogSerialOutput__, ROOM_NAME );
    
    ROOM_NUMBER = new Crestron.Logos.SplusObjects.StringOutput( ROOM_NUMBER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOM_NUMBER__AnalogSerialOutput__, ROOM_NUMBER );
    
    ROOM_IP = new Crestron.Logos.SplusObjects.StringOutput( ROOM_IP__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOM_IP__AnalogSerialOutput__, ROOM_IP );
    
    ROOM_ADDITIONAL = new Crestron.Logos.SplusObjects.StringOutput( ROOM_ADDITIONAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOM_ADDITIONAL__AnalogSerialOutput__, ROOM_ADDITIONAL );
    
    DEBUGMODE = new UShortParameter( DEBUGMODE__Parameter__, this );
    m_ParameterList.Add( DEBUGMODE__Parameter__, DEBUGMODE );
    
    __SPLS_TMPVAR__WAITLABEL_0___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_0___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_1___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_1___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_2___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_2___CallbackFn );
    
    FILENAME.OnSerialChange.Add( new InputChangeHandlerWrapper( FILENAME_OnChange_0, false ) );
    FILELOCATION.OnSerialChange.Add( new InputChangeHandlerWrapper( FILELOCATION_OnChange_1, false ) );
    UPDATE_ROOM_INFO_B.OnDigitalPush.Add( new InputChangeHandlerWrapper( UPDATE_ROOM_INFO_B_OnPush_2, false ) );
    ROOM_INFO_SAVE_B.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_INFO_SAVE_B_OnPush_3, false ) );
    ROOMNAME_SAVE.OnSerialChange.Add( new InputChangeHandlerWrapper( ROOMNAME_SAVE_OnChange_4, false ) );
    ROOMNUMBER_SAVE.OnSerialChange.Add( new InputChangeHandlerWrapper( ROOMNUMBER_SAVE_OnChange_5, false ) );
    ROOMIP_SAVE.OnSerialChange.Add( new InputChangeHandlerWrapper( ROOMIP_SAVE_OnChange_6, false ) );
    ROOMADDITIONAL_SAVE.OnSerialChange.Add( new InputChangeHandlerWrapper( ROOMADDITIONAL_SAVE_OnChange_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ROOM_INFORMATION_HELPER_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_0___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_1___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_2___Callback;


const uint UPDATE_ROOM_INFO_B__DigitalInput__ = 0;
const uint ROOM_INFO_SAVE_B__DigitalInput__ = 1;
const uint ROOMNAME_SAVE__AnalogSerialInput__ = 0;
const uint ROOMNUMBER_SAVE__AnalogSerialInput__ = 1;
const uint ROOMIP_SAVE__AnalogSerialInput__ = 2;
const uint ROOMADDITIONAL_SAVE__AnalogSerialInput__ = 3;
const uint FILENAME__AnalogSerialInput__ = 4;
const uint FILELOCATION__AnalogSerialInput__ = 5;
const uint ROOM_INFO_UPDATE_BUSY_FB__DigitalOutput__ = 0;
const uint ROOM_INFO_SAVE_BUSY_FB__DigitalOutput__ = 1;
const uint ROOM_INFO_SAVE_COMPLETE_PULSE__DigitalOutput__ = 2;
const uint ROOM_NAME__AnalogSerialOutput__ = 0;
const uint ROOM_NUMBER__AnalogSerialOutput__ = 1;
const uint ROOM_IP__AnalogSerialOutput__ = 2;
const uint ROOM_ADDITIONAL__AnalogSerialOutput__ = 3;
const uint DEBUGMODE__Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
