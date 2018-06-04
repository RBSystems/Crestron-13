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

namespace UserModule_FUSION_GUID_UPDATER_HELPER_V1_15
{
    public class UserModuleClass_FUSION_GUID_UPDATER_HELPER_V1_15 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput UPDATE_GUIDS_B;
        Crestron.Logos.SplusObjects.StringInput MASTER_OVERRIDE_GUID_PREFIX__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput CONSOLE_RX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.BufferInput> OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.BufferInput> OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput UPDATE_GUIDS_BUSY_FB;
        Crestron.Logos.SplusObjects.StringOutput UPDATE_GUID_STATUS_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MASTER_GUID_PREFIX_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RVI_FILE_NAME_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RVI_FILE_FULL_PATH_TXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONSOLE_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONSOLE_STATUS_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SYMBOL_GUID_COUNT_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL_GUID_COUNT_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL_ROOM_NAME_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL_IPID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL1_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL2_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL3_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL4_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL5_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL6_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL7_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL8_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL9_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL10_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL11_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL12_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL13_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL14_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL15_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL16_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL17_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL18_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL19_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL20_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL21_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL22_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL23_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL24_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL25_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL26_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL27_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL28_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL29_SLOT_GUID_TXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SYMBOL30_SLOT_GUID_TXT__DOLLAR__;
        UShortParameter PROCESSORMODE;
        UShortParameter PREFIXGUIDS;
        UShortParameter THREESERIESAPPENDSLOTNUMBER;
        StringParameter FILESTORAGELOCATION__DOLLAR__;
        SplusTcpClient TCPCONSOLE;
        ushort G_NCOUNT = 0;
        ushort G_NDEBUG = 0;
        ushort G_NCONSOLESTEP = 0;
        ushort G_NFUSIONDATASTARTED = 0;
        ushort G_NFUSIONSYMBOLDATASTARTED = 0;
        ushort G_NFUSIONSYMBOLCOUNT = 0;
        ushort G_NSEMAPHORE = 0;
        ushort G_NSLOTNUMBER = 0;
        ushort G_NINSTANCEIDFOUND = 0;
        ushort G_NTSIDRETRYCOUNT = 0;
        ushort G_NTSIDUPDATEBUSY = 0;
        ushort G_NRVIFILECHANGED = 0;
        ushort G_NROOMNAMEOVERRIDEALLOWED = 0;
        ushort G_NMASTERGUIDOVERRIDE = 0;
        ushort [] G_NGUIDOVERRIDE;
        ushort [] G_NROOMNAMEUPDATED;
        ushort [] G_NGUIDCOUNT;
        short G_SNCONSOLECONNECTIONOK = 0;
        short G_SNCONSOLECONNECTIONSTATUS = 0;
        CrestronString [] G_SGUIDPREFIX__DOLLAR__;
        CrestronString G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__;
        CrestronString G_SRVITEMP__DOLLAR__;
        CrestronString G_SRVINEWFILETEMP__DOLLAR__;
        CrestronString G_SRVIFULLFILEPATH__DOLLAR__;
        CrestronString G_SRVINEWFULLFILEPATH__DOLLAR__;
        CrestronString G_SRVIFILENAME__DOLLAR__;
        CrestronString G_SRVIFILELOCATION__DOLLAR__;
        CrestronString [] G_SOVERRIDEROOMNAME__DOLLAR__;
        private CrestronString UPDATEGUIDPREFIX (  SplusExecutionContext __context__, CrestronString SCURRENTGUIDPREFIX__DOLLAR__ , ushort NGUIDSYMBOLNUMBER ) 
            { 
            ushort NPROGSLOT2 = 0;
            
            CrestronString SNEWGUIDPREFIX__DOLLAR__;
            SNEWGUIDPREFIX__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 12, this );
            
            
            __context__.SourceCodeLine = 239;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 239;
                Trace( "***** Start UpdateGUIDPrefix *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 240;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 240;
                Trace( "sCurrentGUIDPrefix$ = {0}\r\n", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 241;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 241;
                Trace( "nGUIDSymbolNumber = {0:d}\r\n", (short)NGUIDSYMBOLNUMBER) ; 
                }
            
            __context__.SourceCodeLine = 243;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NGUIDSYMBOLNUMBER == 1000))  ) ) 
                { 
                __context__.SourceCodeLine = 245;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 245;
                    Trace( "Inside if(nGUIDSymbolNumber = cnGUIDMasterOverride)\r\n") ; 
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 247;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NGUIDSYMBOLNUMBER == 1001))  ) ) 
                    { 
                    __context__.SourceCodeLine = 249;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 249;
                        Trace( "Inside else if(nGUIDSymbolNumber = cnGUIDConsoleOverride)\r\n") ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 251;
                    if ( Functions.TestForTrue  ( ( G_NGUIDOVERRIDE[ NGUIDSYMBOLNUMBER ])  ) ) 
                        { 
                        __context__.SourceCodeLine = 253;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 253;
                            Trace( "g_nGUIDOverride[nGUIDSymbolNumber] = {0:d}\r\n", (short)G_NGUIDOVERRIDE[ NGUIDSYMBOLNUMBER ]) ; 
                            }
                        
                        __context__.SourceCodeLine = 254;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 254;
                            Trace( "Inside if(g_nGUIDOverride[nGUIDSymbolNumber]), g_sGUIDPrefix$ = {0}\r\n", G_SGUIDPREFIX__DOLLAR__ [ NGUIDSYMBOLNUMBER ] ) ; 
                            }
                        
                        __context__.SourceCodeLine = 255;
                        MakeString ( SCURRENTGUIDPREFIX__DOLLAR__ , "{0}", G_SGUIDPREFIX__DOLLAR__ [ NGUIDSYMBOLNUMBER ] ) ; 
                        } 
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 258;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)Functions.GetSeries());
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 262;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 262;
                            Trace( "2 Series Processor\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 263;
                        MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 267;
                        NPROGSLOT2 = (ushort) ( GetProgramNumber() ) ; 
                        __context__.SourceCodeLine = 269;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 269;
                            Trace( "3 Series Processor\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 270;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 270;
                            Trace( "nProgSlot2 = {0:d}\r\n", (ushort)NPROGSLOT2) ; 
                            }
                        
                        __context__.SourceCodeLine = 272;
                        if ( Functions.TestForTrue  ( ( THREESERIESAPPENDSLOTNUMBER  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 274;
                            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                {
                                __context__.SourceCodeLine = 274;
                                Trace( "Inside if(ThreeSeriesAppendSlotNumber)\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 275;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 277;
                                MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-01", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 279;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 2))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 281;
                                    MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-02", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 283;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 3))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 285;
                                        MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-03", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 287;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 4))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 289;
                                            MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-04", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 291;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 5))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 293;
                                                MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-05", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 295;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 6))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 297;
                                                    MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-06", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 299;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 7))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 301;
                                                        MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-07", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 303;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 8))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 305;
                                                            MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-08", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 307;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 9))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 309;
                                                                MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-09", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 311;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT2 == 10))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 313;
                                                                    MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}-10", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 318;
                            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                {
                                __context__.SourceCodeLine = 318;
                                Trace( "Inside ELSE FOR if(ThreeSeriesAppendSlotNumber)\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 319;
                            MakeString ( SNEWGUIDPREFIX__DOLLAR__ , "{0}", SCURRENTGUIDPREFIX__DOLLAR__ ) ; 
                            } 
                        
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 324;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 324;
                Trace( "sNewGUIDPrefix$ = {0}\r\n", SNEWGUIDPREFIX__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 325;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 325;
                Trace( "***** End UpdateGUIDPrefix *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 327;
            return ( SNEWGUIDPREFIX__DOLLAR__ ) ; 
            
            }
            
        private CrestronString GETRVISEARCHLOCATION (  SplusExecutionContext __context__ ) 
            { 
            ushort NPROGSLOT = 0;
            
            
            __context__.SourceCodeLine = 334;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 334;
                Trace( "***** Start GetRVISearchLocation *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 336;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Determining Processor Type...") ; 
            __context__.SourceCodeLine = 338;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)Functions.GetSeries());
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 342;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 342;
                            Trace( "2 Series Processor\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 343;
                        MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}", "\\SIMPL\\" ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 347;
                        NPROGSLOT = (ushort) ( GetProgramNumber() ) ; 
                        __context__.SourceCodeLine = 349;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 349;
                            Trace( "3 Series Processor\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 350;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 350;
                            Trace( "nProgSlot = {0:d}\r\n", (ushort)NPROGSLOT) ; 
                            }
                        
                        __context__.SourceCodeLine = 352;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 354;
                            MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App01\\", "\\SIMPL\\" ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 356;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 2))  ) ) 
                                { 
                                __context__.SourceCodeLine = 358;
                                MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App02\\", "\\SIMPL\\" ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 360;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 3))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 362;
                                    MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App03\\", "\\SIMPL\\" ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 364;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 4))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 366;
                                        MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App04\\", "\\SIMPL\\" ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 368;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 5))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 370;
                                            MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App05\\", "\\SIMPL\\" ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 372;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 6))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 374;
                                                MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App06\\", "\\SIMPL\\" ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 376;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 7))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 378;
                                                    MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App07\\", "\\SIMPL\\" ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 380;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 8))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 382;
                                                        MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App08\\", "\\SIMPL\\" ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 384;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 9))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 386;
                                                            MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App09\\", "\\SIMPL\\" ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 388;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NPROGSLOT == 10))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 390;
                                                                MakeString ( G_SRVIFILELOCATION__DOLLAR__ , "{0}App10\\", "\\SIMPL\\" ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 395;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 395;
                Trace( "g_sRVIFileLocation$ = {0}\r\n", G_SRVIFILELOCATION__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 396;
            return ( G_SRVIFILELOCATION__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 398;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 398;
                Trace( "***** End GetRVISearchLocation *****\r\n") ; 
                }
            
            
            }
            
        private CrestronString FINDRVIFILE (  SplusExecutionContext __context__ ) 
            { 
            FILE_INFO FIFILEINFO;
            FIFILEINFO  = new FILE_INFO();
            FIFILEINFO .PopulateDefaults();
            
            CrestronString SRVIFILENAME__DOLLAR__;
            CrestronString SRVISEARCHPATH__DOLLAR__;
            SRVIFILENAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            SRVISEARCHPATH__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            short SNRVIFILEFOUND = 0;
            short SNSTARTFILEIOERROR = 0;
            short SNENDFILEIOERROR = 0;
            
            
            __context__.SourceCodeLine = 407;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 407;
                Trace( "***** Start FindRVIFile *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 409;
            GETRVISEARCHLOCATION (  __context__  ) ; 
            __context__.SourceCodeLine = 411;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Finding RVI File...") ; 
            __context__.SourceCodeLine = 413;
            MakeString ( SRVISEARCHPATH__DOLLAR__ , "{0}{1}", G_SRVIFILELOCATION__DOLLAR__ , "*.rvi" ) ; 
            __context__.SourceCodeLine = 415;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 415;
                Trace( "sRVISearchPath$ = {0}\r\n", SRVISEARCHPATH__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 417;
            SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
            __context__.SourceCodeLine = 418;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNSTARTFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 420;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 420;
                    Trace( "Start File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 421;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 422;
                SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
                __context__.SourceCodeLine = 418;
                } 
            
            __context__.SourceCodeLine = 424;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)Functions.GetSeries());
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 428;
                        SNRVIFILEFOUND = (short) ( FindFirst( SRVISEARCHPATH__DOLLAR__ , ref FIFILEINFO ) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 432;
                        SNRVIFILEFOUND = (short) ( FindFirstShared( SRVISEARCHPATH__DOLLAR__ , ref FIFILEINFO ) ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 436;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 436;
                Trace( "snRVIFileFound = {0:d}\r\n", (short)SNRVIFILEFOUND) ; 
                }
            
            __context__.SourceCodeLine = 437;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNRVIFILEFOUND == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 439;
                MakeString ( SRVIFILENAME__DOLLAR__ , "{0}", FIFILEINFO .  Name ) ; 
                __context__.SourceCodeLine = 440;
                MakeString ( G_SRVIFILENAME__DOLLAR__ , "{0}", FIFILEINFO .  Name ) ; 
                __context__.SourceCodeLine = 441;
                MakeString ( RVI_FILE_NAME_TXT__DOLLAR__ , "{0}", G_SRVIFILENAME__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 442;
                MakeString ( RVI_FILE_FULL_PATH_TXT__DOLLAR__ , "{0}{1}", G_SRVIFILELOCATION__DOLLAR__ , G_SRVIFILENAME__DOLLAR__ ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 446;
                MakeString ( SRVIFILENAME__DOLLAR__ , "{0}", "FileFoundError" ) ; 
                __context__.SourceCodeLine = 447;
                MakeString ( G_SRVIFILENAME__DOLLAR__ , "{0}", "FileFoundError" ) ; 
                __context__.SourceCodeLine = 448;
                MakeString ( RVI_FILE_NAME_TXT__DOLLAR__ , "{0}", "FileFoundError" ) ; 
                __context__.SourceCodeLine = 449;
                MakeString ( RVI_FILE_FULL_PATH_TXT__DOLLAR__ , "{0}", "FileFoundError" ) ; 
                } 
            
            __context__.SourceCodeLine = 451;
            SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
            __context__.SourceCodeLine = 452;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNENDFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 454;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 454;
                    Trace( "End File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 455;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 456;
                SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
                __context__.SourceCodeLine = 452;
                } 
            
            __context__.SourceCodeLine = 459;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 459;
                Trace( "sRVIFileName$ = {0}\r\n", SRVIFILENAME__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 460;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 460;
                Trace( "g_sRVIFileName$ = {0}\r\n", G_SRVIFILENAME__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 461;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 461;
                Trace( "g_sRVIFileLocation$ = {0}\r\n", G_SRVIFILELOCATION__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 463;
            return ( SRVIFILENAME__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 465;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 465;
                Trace( "***** End FindRVIFile *****\r\n") ; 
                }
            
            
            }
            
        private void WRITETEMPFILE (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SFILEWRITEPATH__DOLLAR__;
            SFILEWRITEPATH__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            ushort NFILELEN = 0;
            
            short SNFILEHANDLE = 0;
            short SNNUMWRITE = 0;
            short SNSTARTFILEIOERROR = 0;
            short SNENDFILEIOERROR = 0;
            short SNFILECLOSEERROR = 0;
            
            
            __context__.SourceCodeLine = 474;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 474;
                Trace( "***** Start WriteTempFile *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 476;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Writing Data To File...") ; 
            __context__.SourceCodeLine = 478;
            MakeString ( SFILEWRITEPATH__DOLLAR__ , "{0}{1}", FILESTORAGELOCATION__DOLLAR__ , G_SRVIFILENAME__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 479;
            MakeString ( G_SRVINEWFULLFILEPATH__DOLLAR__ , "{0}{1}", FILESTORAGELOCATION__DOLLAR__ , G_SRVIFILENAME__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 481;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 481;
                Trace( "sFileWritePath$ = {0}\r\n", SFILEWRITEPATH__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 482;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 482;
                Trace( "cs2SeriesDebugTempRVIFile = {0}\r\n", "\\NVRAM\\Fusion GUID Updater Simple Test Pro2 10-21-2013 rev3.rvi" ) ; 
                }
            
            __context__.SourceCodeLine = 484;
            SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
            __context__.SourceCodeLine = 485;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNSTARTFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 487;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 487;
                    Trace( "Start File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 488;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 489;
                SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
                __context__.SourceCodeLine = 485;
                } 
            
            __context__.SourceCodeLine = 491;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                { 
                __context__.SourceCodeLine = 493;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_4__ = ((int)Functions.GetSeries());
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 497;
                            SNFILEHANDLE = (short) ( FileOpen( "\\NVRAM\\Fusion GUID Updater Simple Test Pro2 10-21-2013 rev3.rvi" ,(ushort) (((1 | 256) | 8) | 16384) ) ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 501;
                            SNFILEHANDLE = (short) ( FileOpenShared( "\\NVRAM\\ADG-PV-Room_230-140310.rvi" ,(ushort) (((1 | 256) | 8) | 16384) ) ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 507;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_5__ = ((int)Functions.GetSeries());
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 511;
                            SNFILEHANDLE = (short) ( FileOpen( SFILEWRITEPATH__DOLLAR__ ,(ushort) (((1 | 256) | 8) | 16384) ) ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 515;
                            SNFILEHANDLE = (short) ( FileOpenShared( SFILEWRITEPATH__DOLLAR__ ,(ushort) (((1 | 256) | 8) | 16384) ) ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            
            __context__.SourceCodeLine = 520;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                { 
                __context__.SourceCodeLine = 522;
                Trace( "FileOpen Complete\r\n") ; 
                __context__.SourceCodeLine = 523;
                Trace( "snFileHandle = {0:d}\r\n", (short)SNFILEHANDLE) ; 
                } 
            
            __context__.SourceCodeLine = 526;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SNFILEHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 528;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 528;
                    Trace( "***** Inside if(snFileHandle >= 0) *****\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 529;
                NFILELEN = (ushort) ( Functions.Length( G_SRVINEWFILETEMP__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 530;
                SNNUMWRITE = (short) ( FileWrite( (short)( SNFILEHANDLE ) , G_SRVINEWFILETEMP__DOLLAR__ , (ushort)( NFILELEN ) ) ) ; 
                __context__.SourceCodeLine = 531;
                SNFILECLOSEERROR = (short) ( FileClose( (short)( SNFILEHANDLE ) ) ) ; 
                __context__.SourceCodeLine = 532;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNFILECLOSEERROR != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 534;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 534;
                        Trace( "File Close Error Retrying\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 535;
                    Functions.Delay (  (int) ( 100 ) ) ; 
                    __context__.SourceCodeLine = 536;
                    SNFILECLOSEERROR = (short) ( FileClose( (short)( SNFILEHANDLE ) ) ) ; 
                    __context__.SourceCodeLine = 532;
                    } 
                
                __context__.SourceCodeLine = 539;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 539;
                    Trace( "g_sRVINewFileTemp$ = {0}\r\n", G_SRVINEWFILETEMP__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 540;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 540;
                    Trace( "nFileLen = {0:d}\r\n", (short)NFILELEN) ; 
                    }
                
                __context__.SourceCodeLine = 541;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 541;
                    Trace( "snNumWrite = {0:d}\r\n", (short)SNNUMWRITE) ; 
                    }
                
                __context__.SourceCodeLine = 543;
                Functions.ClearBuffer ( G_SRVINEWFILETEMP__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 545;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( G_NDEBUG ) && Functions.TestForTrue ( Functions.BoolToInt ( SNNUMWRITE < 0 ) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 545;
                    Trace( "Error Writing to File\r\n") ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 549;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 549;
                    Trace( "***** Error Entering if(snFileHandle >= 0) *****\r\n") ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 551;
            SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
            __context__.SourceCodeLine = 552;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNENDFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 554;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 554;
                    Trace( "End File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 555;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 556;
                SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
                __context__.SourceCodeLine = 552;
                } 
            
            __context__.SourceCodeLine = 559;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 559;
                Trace( "***** End WriteTempFile *****\r\n") ; 
                }
            
            
            }
            
        private CrestronString ADDNEWFILEDATA (  SplusExecutionContext __context__, CrestronString SCURRENTDATA__DOLLAR__ ) 
            { 
            
            __context__.SourceCodeLine = 564;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SRVINEWFILETEMP__DOLLAR__ != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 566;
                MakeString ( G_SRVINEWFILETEMP__DOLLAR__ , "{0}{1}", G_SRVINEWFILETEMP__DOLLAR__ , SCURRENTDATA__DOLLAR__ ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 570;
                MakeString ( G_SRVINEWFILETEMP__DOLLAR__ , "{0}", SCURRENTDATA__DOLLAR__ ) ; 
                } 
            
            
            return ""; // default return value (none specified in module)
            }
            
        private CrestronString GETROOMNAME (  SplusExecutionContext __context__, ushort NCURRENTSYMBOLCOUNT , CrestronString SCURRENTDATA__DOLLAR__ ) 
            { 
            ushort NSTARTPOSITION = 0;
            ushort NENDPOSITION = 0;
            ushort NCOUNT = 0;
            
            CrestronString SROOMNAMERETURN__DOLLAR__;
            SROOMNAMERETURN__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 579;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SOVERRIDEROOMNAME__DOLLAR__[ NCURRENTSYMBOLCOUNT ] != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 581;
                MakeString ( SROOMNAMERETURN__DOLLAR__ , "{0}", G_SOVERRIDEROOMNAME__DOLLAR__ [ NCURRENTSYMBOLCOUNT ] ) ; 
                __context__.SourceCodeLine = 582;
                G_NRVIFILECHANGED = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 583;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 583;
                    Trace( "Line 451 g_nRVIFileChanged = {0:d}\r\n", (short)G_NRVIFILECHANGED) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 587;
                NSTARTPOSITION = (ushort) ( (Functions.Find( "<RoomName>" , SCURRENTDATA__DOLLAR__ ) + Functions.Length( "<RoomName>" )) ) ; 
                __context__.SourceCodeLine = 588;
                NENDPOSITION = (ushort) ( Functions.Find( "</RoomName>" , SCURRENTDATA__DOLLAR__ , NSTARTPOSITION ) ) ; 
                __context__.SourceCodeLine = 589;
                NCOUNT = (ushort) ( (NENDPOSITION - NSTARTPOSITION) ) ; 
                __context__.SourceCodeLine = 590;
                MakeString ( SROOMNAMERETURN__DOLLAR__ , "{0}", Functions.Mid ( SCURRENTDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 593;
            return ( SROOMNAMERETURN__DOLLAR__ ) ; 
            
            }
            
        private CrestronString GETNODENAME (  SplusExecutionContext __context__, ushort NCURRENTSYMBOLCOUNT , CrestronString SCURRENTDATA__DOLLAR__ ) 
            { 
            ushort NSTARTPOSITION = 0;
            ushort NENDPOSITION = 0;
            ushort NCOUNT = 0;
            
            CrestronString SNODENAMERETURN__DOLLAR__;
            SNODENAMERETURN__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 601;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SOVERRIDEROOMNAME__DOLLAR__[ NCURRENTSYMBOLCOUNT ] != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 603;
                MakeString ( SNODENAMERETURN__DOLLAR__ , "{0}", G_SOVERRIDEROOMNAME__DOLLAR__ [ NCURRENTSYMBOLCOUNT ] ) ; 
                __context__.SourceCodeLine = 604;
                G_NRVIFILECHANGED = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 605;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 605;
                    Trace( "Line 473 g_nRVIFileChanged = {0:d}\r\n", (short)G_NRVIFILECHANGED) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 609;
                NSTARTPOSITION = (ushort) ( (Functions.Find( "<NodeName>" , SCURRENTDATA__DOLLAR__ ) + Functions.Length( "<NodeName>" )) ) ; 
                __context__.SourceCodeLine = 610;
                NENDPOSITION = (ushort) ( Functions.Find( "</NodeName>" , SCURRENTDATA__DOLLAR__ , NSTARTPOSITION ) ) ; 
                __context__.SourceCodeLine = 611;
                NCOUNT = (ushort) ( (NENDPOSITION - NSTARTPOSITION) ) ; 
                __context__.SourceCodeLine = 612;
                MakeString ( SNODENAMERETURN__DOLLAR__ , "{0}", Functions.Mid ( SCURRENTDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 615;
            return ( SNODENAMERETURN__DOLLAR__ ) ; 
            
            }
            
        private CrestronString PARSERVIFILEDATA (  SplusExecutionContext __context__, CrestronString SRVITEMPFILEDATA__DOLLAR__ ) 
            { 
            ushort NSTARTPOSITION = 0;
            ushort NENDPOSITION = 0;
            ushort NCOUNT = 0;
            
            CrestronString STEMPDATA__DOLLAR__;
            CrestronString SRVITEMPNEWFILEDATA__DOLLAR__;
            CrestronString STEMPROOMNAME__DOLLAR__;
            CrestronString STEMPROOMNAMEDATA__DOLLAR__;
            CrestronString STEMPROOMGUID__DOLLAR__;
            CrestronString STEMPINSTANCEGUID__DOLLAR__;
            STEMPDATA__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            SRVITEMPNEWFILEDATA__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5500, this );
            STEMPROOMNAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            STEMPROOMNAMEDATA__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            STEMPROOMGUID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            STEMPINSTANCEGUID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 625;
            NSTARTPOSITION = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 626;
            NENDPOSITION = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 627;
            NCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 629;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Processing Data...") ; 
            __context__.SourceCodeLine = 631;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 631;
                Trace( "***** Start ParseRVIFile *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 633;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SRVITEMP__DOLLAR__ != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 635;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 635;
                    Trace( "g_sRVITemp$ <> \u0022\u0022 = True\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 636;
                MakeString ( G_SRVITEMP__DOLLAR__ , "{0}{1}", G_SRVITEMP__DOLLAR__ , SRVITEMPFILEDATA__DOLLAR__ ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 640;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 640;
                    Trace( "g_sRVITemp$ <> \u0022\u0022 = False\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 641;
                MakeString ( G_SRVITEMP__DOLLAR__ , "{0}", SRVITEMPFILEDATA__DOLLAR__ ) ; 
                } 
            
            __context__.SourceCodeLine = 643;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 643;
                Trace( "len(g_sRVITemp$) = {0:d}\r\nlen(sRVITempFileData$) = {1:d}\r\n", (ushort)Functions.Length( G_SRVITEMP__DOLLAR__ ), (ushort)Functions.Length( SRVITEMPFILEDATA__DOLLAR__ )) ; 
                }
            
            __context__.SourceCodeLine = 645;
            while ( Functions.TestForTrue  ( ( Functions.Find( "\r\n" , G_SRVITEMP__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 647;
                STEMPDATA__DOLLAR__  .UpdateValue ( Functions.Remove ( "\r\n" , G_SRVITEMP__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 648;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "<SymbolInfo>" , STEMPDATA__DOLLAR__ ) ) || Functions.TestForTrue ( G_NFUSIONSYMBOLDATASTARTED )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 650;
                    G_NFUSIONSYMBOLDATASTARTED = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 651;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 651;
                        Trace( "sTempData$ = {0}\r\n", STEMPDATA__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 652;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( Functions.Find( "</SymbolInfo>" , STEMPDATA__DOLLAR__ ) ) ) && Functions.TestForTrue ( Functions.Find( "\r\n" , STEMPDATA__DOLLAR__ ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 654;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "<RoomName>" , STEMPDATA__DOLLAR__ ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 656;
                            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                {
                                __context__.SourceCodeLine = 656;
                                Trace( "**Room Name Segment***\r\n sTempData$ = {0}\r\n", STEMPDATA__DOLLAR__ ) ; 
                                }
                            
                            __context__.SourceCodeLine = 657;
                            MakeString ( STEMPROOMNAME__DOLLAR__ , "{0}", GETROOMNAME (  __context__ , (ushort)( G_NFUSIONSYMBOLCOUNT ), STEMPDATA__DOLLAR__) ) ; 
                            __context__.SourceCodeLine = 658;
                            MakeString ( SYMBOL_ROOM_NAME_TXT__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT] , "{0}", STEMPROOMNAME__DOLLAR__ ) ; 
                            __context__.SourceCodeLine = 659;
                            MakeString ( STEMPROOMNAMEDATA__DOLLAR__ , "          {0}{1}{2}\r\n", "<RoomName>" , STEMPROOMNAME__DOLLAR__ , "</RoomName>" ) ; 
                            __context__.SourceCodeLine = 660;
                            ADDNEWFILEDATA (  __context__ , STEMPROOMNAMEDATA__DOLLAR__) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 662;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "<NodeName>" , STEMPDATA__DOLLAR__ ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 664;
                                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                    {
                                    __context__.SourceCodeLine = 664;
                                    Trace( "**Node Name Segment***\r\n sTempData$ = {0}\r\n", STEMPDATA__DOLLAR__ ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 665;
                                MakeString ( STEMPROOMNAME__DOLLAR__ , "{0}", GETNODENAME (  __context__ , (ushort)( G_NFUSIONSYMBOLCOUNT ), STEMPDATA__DOLLAR__) ) ; 
                                __context__.SourceCodeLine = 666;
                                MakeString ( SYMBOL_ROOM_NAME_TXT__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT] , "{0}", STEMPROOMNAME__DOLLAR__ ) ; 
                                __context__.SourceCodeLine = 667;
                                MakeString ( STEMPROOMNAMEDATA__DOLLAR__ , "          {0}{1}{2}\r\n", "<NodeName>" , STEMPROOMNAME__DOLLAR__ , "</NodeName>" ) ; 
                                __context__.SourceCodeLine = 668;
                                ADDNEWFILEDATA (  __context__ , STEMPROOMNAMEDATA__DOLLAR__) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 670;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "<InstanceID>" , STEMPDATA__DOLLAR__ ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 672;
                                    NSTARTPOSITION = (ushort) ( (Functions.Find( "<InstanceID>" , STEMPDATA__DOLLAR__ ) + Functions.Length( "<InstanceID>" )) ) ; 
                                    __context__.SourceCodeLine = 673;
                                    NENDPOSITION = (ushort) ( Functions.Find( "</InstanceID>" , STEMPDATA__DOLLAR__ , NSTARTPOSITION ) ) ; 
                                    __context__.SourceCodeLine = 674;
                                    NCOUNT = (ushort) ( (NENDPOSITION - NSTARTPOSITION) ) ; 
                                    __context__.SourceCodeLine = 675;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( G_SGUIDPREFIX__DOLLAR__[ G_NFUSIONSYMBOLCOUNT ] , STEMPDATA__DOLLAR__ ) ) || Functions.TestForTrue ( Functions.BoolToInt (PREFIXGUIDS  .Value == 0) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 677;
                                        MakeString ( SYMBOL_GUID_TXT__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                        __context__.SourceCodeLine = 678;
                                        ADDNEWFILEDATA (  __context__ , STEMPDATA__DOLLAR__) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 682;
                                        G_NRVIFILECHANGED = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 683;
                                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 683;
                                            Trace( "Line 551 g_nRVIFileChanged = {0:d}\r\n", (short)G_NRVIFILECHANGED) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 684;
                                        MakeString ( STEMPROOMGUID__DOLLAR__ , "          {0}{1}-{2}{3}\r\n", "<InstanceID>" , G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) , "</InstanceID>" ) ; 
                                        __context__.SourceCodeLine = 685;
                                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 685;
                                            Trace( "sTempRoomGUID$ = {0}\r\n", STEMPROOMGUID__DOLLAR__ ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 686;
                                        MakeString ( SYMBOL_GUID_TXT__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                        __context__.SourceCodeLine = 687;
                                        ADDNEWFILEDATA (  __context__ , STEMPROOMGUID__DOLLAR__) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 690;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "<IPID>" , STEMPDATA__DOLLAR__ ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 692;
                                        NSTARTPOSITION = (ushort) ( (Functions.Find( "<IPID>" , STEMPDATA__DOLLAR__ ) + Functions.Length( "<IPID>" )) ) ; 
                                        __context__.SourceCodeLine = 693;
                                        NENDPOSITION = (ushort) ( Functions.Find( "</IPID>" , STEMPDATA__DOLLAR__ , NSTARTPOSITION ) ) ; 
                                        __context__.SourceCodeLine = 694;
                                        NCOUNT = (ushort) ( (NENDPOSITION - NSTARTPOSITION) ) ; 
                                        __context__.SourceCodeLine = 695;
                                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                            {
                                            __context__.SourceCodeLine = 695;
                                            Trace( "**IP ID Segment***\r\n sTempData$ = {0}\r\n nStartPosition = {1:d}\r\n nEndPosition = {2:d}\r\n nCount = {3:d}\r\n", STEMPDATA__DOLLAR__ , (ushort)NSTARTPOSITION, (ushort)NENDPOSITION, (ushort)NCOUNT) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 696;
                                        MakeString ( SYMBOL_IPID_TXT__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                        __context__.SourceCodeLine = 697;
                                        ADDNEWFILEDATA (  __context__ , STEMPDATA__DOLLAR__) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 699;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "<SlotNum>" , STEMPDATA__DOLLAR__ ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 701;
                                            NSTARTPOSITION = (ushort) ( (Functions.Find( "<SlotNum>" , STEMPDATA__DOLLAR__ ) + Functions.Length( "<SlotNum>" )) ) ; 
                                            __context__.SourceCodeLine = 702;
                                            NENDPOSITION = (ushort) ( Functions.Find( "</SlotNum>" , STEMPDATA__DOLLAR__ , NSTARTPOSITION ) ) ; 
                                            __context__.SourceCodeLine = 703;
                                            NCOUNT = (ushort) ( (NENDPOSITION - NSTARTPOSITION) ) ; 
                                            __context__.SourceCodeLine = 704;
                                            G_NSLOTNUMBER = (ushort) ( Functions.Atoi( Functions.Mid( STEMPDATA__DOLLAR__ , (int)( NSTARTPOSITION ) , (int)( NCOUNT ) ) ) ) ; 
                                            __context__.SourceCodeLine = 705;
                                            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                {
                                                __context__.SourceCodeLine = 705;
                                                Trace( "**Slot Number Segment***\r\n sTempData$ = {0}\r\n nStartPosition = {1:d}\r\n nEndPosition = {2:d}\r\n nCount = {3:d}\r\n g_nSlotNumber = {4:d}\r\n", STEMPDATA__DOLLAR__ , (ushort)NSTARTPOSITION, (ushort)NENDPOSITION, (ushort)NCOUNT, (ushort)G_NSLOTNUMBER) ; 
                                                }
                                            
                                            __context__.SourceCodeLine = 706;
                                            ADDNEWFILEDATA (  __context__ , STEMPDATA__DOLLAR__) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 708;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "<Name>InstanceID</Name>" , STEMPDATA__DOLLAR__ ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 710;
                                                G_NINSTANCEIDFOUND = (ushort) ( 1 ) ; 
                                                __context__.SourceCodeLine = 711;
                                                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                    {
                                                    __context__.SourceCodeLine = 711;
                                                    Trace( "***csParamSeachType Found***\r\n") ; 
                                                    }
                                                
                                                __context__.SourceCodeLine = 712;
                                                ADDNEWFILEDATA (  __context__ , STEMPDATA__DOLLAR__) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 714;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( G_NINSTANCEIDFOUND ) && Functions.TestForTrue ( Functions.Find( "<Value>" , STEMPDATA__DOLLAR__ ) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 716;
                                                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 716;
                                                        Trace( "***else if(g_nInstanceIDFound && find(csParamGUIDStartofData, sTempData$)) Found***\r\n") ; 
                                                        }
                                                    
                                                    __context__.SourceCodeLine = 717;
                                                    NSTARTPOSITION = (ushort) ( (Functions.Find( "<Value>" , STEMPDATA__DOLLAR__ ) + Functions.Length( "<Value>" )) ) ; 
                                                    __context__.SourceCodeLine = 718;
                                                    NENDPOSITION = (ushort) ( Functions.Find( "</Value>" , STEMPDATA__DOLLAR__ , NSTARTPOSITION ) ) ; 
                                                    __context__.SourceCodeLine = 719;
                                                    NCOUNT = (ushort) ( (NENDPOSITION - NSTARTPOSITION) ) ; 
                                                    __context__.SourceCodeLine = 721;
                                                    G_NGUIDCOUNT [ G_NFUSIONSYMBOLCOUNT] = (ushort) ( (G_NGUIDCOUNT[ G_NFUSIONSYMBOLCOUNT ] + 1) ) ; 
                                                    __context__.SourceCodeLine = 723;
                                                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 723;
                                                        Trace( "g_nFusionSymbolCount = {0:d}\r\n", (ushort)G_NFUSIONSYMBOLCOUNT) ; 
                                                        }
                                                    
                                                    __context__.SourceCodeLine = 724;
                                                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 724;
                                                        Trace( "nSlotNumber = {0:d}\r\n", (ushort)G_NSLOTNUMBER) ; 
                                                        }
                                                    
                                                    __context__.SourceCodeLine = 725;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( G_SGUIDPREFIX__DOLLAR__[ G_NFUSIONSYMBOLCOUNT ] , STEMPDATA__DOLLAR__ ) ) || Functions.TestForTrue ( Functions.BoolToInt (PREFIXGUIDS  .Value == 0) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 727;
                                                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 727;
                                                            Trace( "***if(find(g_sGUIDPrefix$[g_nFusionSymbolCount], sTempData$)) Found***\r\n") ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 728;
                                                        
                                                            {
                                                            int __SPLS_TMPVAR__SWTCH_6__ = ((int)G_NFUSIONSYMBOLCOUNT);
                                                            
                                                                { 
                                                                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 732;
                                                                    MakeString ( SYMBOL1_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 736;
                                                                    MakeString ( SYMBOL2_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 740;
                                                                    MakeString ( SYMBOL3_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 4) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 744;
                                                                    MakeString ( SYMBOL4_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 5) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 748;
                                                                    MakeString ( SYMBOL5_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 6) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 752;
                                                                    MakeString ( SYMBOL6_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 7) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 756;
                                                                    MakeString ( SYMBOL7_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 8) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 760;
                                                                    MakeString ( SYMBOL8_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 9) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 764;
                                                                    MakeString ( SYMBOL9_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 10) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 768;
                                                                    MakeString ( SYMBOL10_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 11) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 772;
                                                                    MakeString ( SYMBOL11_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 12) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 776;
                                                                    MakeString ( SYMBOL12_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 13) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 780;
                                                                    MakeString ( SYMBOL13_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 14) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 784;
                                                                    MakeString ( SYMBOL14_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 15) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 788;
                                                                    MakeString ( SYMBOL15_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 16) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 792;
                                                                    MakeString ( SYMBOL16_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 17) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 796;
                                                                    MakeString ( SYMBOL17_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 18) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 800;
                                                                    MakeString ( SYMBOL18_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 19) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 804;
                                                                    MakeString ( SYMBOL19_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 20) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 808;
                                                                    MakeString ( SYMBOL20_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 21) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 812;
                                                                    MakeString ( SYMBOL21_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 22) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 816;
                                                                    MakeString ( SYMBOL22_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 23) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 820;
                                                                    MakeString ( SYMBOL23_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 24) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 824;
                                                                    MakeString ( SYMBOL24_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 25) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 828;
                                                                    MakeString ( SYMBOL25_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 26) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 832;
                                                                    MakeString ( SYMBOL26_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 27) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 836;
                                                                    MakeString ( SYMBOL27_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 28) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 840;
                                                                    MakeString ( SYMBOL28_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 29) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 844;
                                                                    MakeString ( SYMBOL29_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 30) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 848;
                                                                    MakeString ( SYMBOL30_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}", Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                } 
                                                                
                                                            }
                                                            
                                                        
                                                        __context__.SourceCodeLine = 851;
                                                        ADDNEWFILEDATA (  __context__ , STEMPDATA__DOLLAR__) ; 
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 855;
                                                        G_NRVIFILECHANGED = (ushort) ( 1 ) ; 
                                                        __context__.SourceCodeLine = 856;
                                                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 856;
                                                            Trace( "Line 724 g_nRVIFileChanged = {0:d}\r\n", (short)G_NRVIFILECHANGED) ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 857;
                                                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 857;
                                                            Trace( "***if(find(g_sGUIDPrefix$[g_nFusionSymbolCount], sTempData$)) ELSE Found***\r\n") ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 858;
                                                        MakeString ( STEMPINSTANCEGUID__DOLLAR__ , "                    {0}{1}-{2}{3}\r\n", "<Value>" , G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) , "</Value>" ) ; 
                                                        __context__.SourceCodeLine = 859;
                                                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 859;
                                                            Trace( "sTempInstanceGUID$ = {0}\r\n", STEMPINSTANCEGUID__DOLLAR__ ) ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 860;
                                                        
                                                            {
                                                            int __SPLS_TMPVAR__SWTCH_7__ = ((int)G_NFUSIONSYMBOLCOUNT);
                                                            
                                                                { 
                                                                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 864;
                                                                    MakeString ( SYMBOL1_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 868;
                                                                    MakeString ( SYMBOL2_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 3) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 872;
                                                                    MakeString ( SYMBOL3_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 4) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 876;
                                                                    MakeString ( SYMBOL4_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 5) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 880;
                                                                    MakeString ( SYMBOL5_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 6) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 884;
                                                                    MakeString ( SYMBOL6_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 7) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 888;
                                                                    MakeString ( SYMBOL7_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 8) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 892;
                                                                    MakeString ( SYMBOL8_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 9) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 896;
                                                                    MakeString ( SYMBOL9_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 10) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 900;
                                                                    MakeString ( SYMBOL10_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 11) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 904;
                                                                    MakeString ( SYMBOL11_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 12) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 908;
                                                                    MakeString ( SYMBOL12_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 13) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 912;
                                                                    MakeString ( SYMBOL13_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 14) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 916;
                                                                    MakeString ( SYMBOL14_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 15) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 920;
                                                                    MakeString ( SYMBOL15_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 16) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 924;
                                                                    MakeString ( SYMBOL16_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 17) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 928;
                                                                    MakeString ( SYMBOL17_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 18) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 932;
                                                                    MakeString ( SYMBOL18_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 19) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 936;
                                                                    MakeString ( SYMBOL19_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 20) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 940;
                                                                    MakeString ( SYMBOL20_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 21) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 944;
                                                                    MakeString ( SYMBOL21_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 22) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 948;
                                                                    MakeString ( SYMBOL22_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 23) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 952;
                                                                    MakeString ( SYMBOL23_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 24) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 956;
                                                                    MakeString ( SYMBOL24_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 25) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 960;
                                                                    MakeString ( SYMBOL25_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 26) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 964;
                                                                    MakeString ( SYMBOL26_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 27) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 968;
                                                                    MakeString ( SYMBOL27_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 28) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 972;
                                                                    MakeString ( SYMBOL28_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 29) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 976;
                                                                    MakeString ( SYMBOL29_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 30) ) ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 980;
                                                                    MakeString ( SYMBOL30_SLOT_GUID_TXT__DOLLAR__ [ G_NSLOTNUMBER] , "{0}-{1}", G_SGUIDPREFIX__DOLLAR__ [ G_NFUSIONSYMBOLCOUNT ] , Functions.Mid ( STEMPDATA__DOLLAR__ ,  (int) ( NSTARTPOSITION ) ,  (int) ( NCOUNT ) ) ) ; 
                                                                    } 
                                                                
                                                                } 
                                                                
                                                            }
                                                            
                                                        
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 984;
                                                    G_NINSTANCEIDFOUND = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 985;
                                                    ADDNEWFILEDATA (  __context__ , STEMPINSTANCEGUID__DOLLAR__) ; 
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 989;
                                                    ADDNEWFILEDATA (  __context__ , STEMPDATA__DOLLAR__) ; 
                                                    } 
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        __context__.SourceCodeLine = 992;
                        STEMPDATA__DOLLAR__  .UpdateValue ( Functions.Remove ( "\r\n" , G_SRVITEMP__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 993;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 993;
                            Trace( "sTempData$ = {0}\r\n", STEMPDATA__DOLLAR__ ) ; 
                            }
                        
                        __context__.SourceCodeLine = 652;
                        } 
                    
                    __context__.SourceCodeLine = 995;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</SymbolInfo>" , STEMPDATA__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 997;
                        ADDNEWFILEDATA (  __context__ , STEMPDATA__DOLLAR__) ; 
                        __context__.SourceCodeLine = 998;
                        G_NFUSIONSYMBOLDATASTARTED = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 999;
                        G_NFUSIONSYMBOLCOUNT = (ushort) ( (G_NFUSIONSYMBOLCOUNT + 1) ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1004;
                    ADDNEWFILEDATA (  __context__ , STEMPDATA__DOLLAR__) ; 
                    } 
                
                __context__.SourceCodeLine = 645;
                } 
            
            __context__.SourceCodeLine = 1008;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PREFIXGUIDS  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1010;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1010;
                    Trace( "Inside if(PrefixGUIDs = cnTrue)\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1011;
                WRITETEMPFILE (  __context__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1015;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1015;
                    Trace( "Inside ELSE if(PrefixGUIDs = cnTrue)\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1016;
                Functions.ClearBuffer ( G_SRVINEWFILETEMP__DOLLAR__ ) ; 
                } 
            
            __context__.SourceCodeLine = 1018;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1018;
                Trace( "***** End ParseRVIFile *****\r\n") ; 
                }
            
            
            return ""; // default return value (none specified in module)
            }
            
        private void PROCESSRVIFILE (  SplusExecutionContext __context__, CrestronString SRVIFILE__DOLLAR__ ) 
            { 
            short SNFILEHANDLE = 0;
            short SNSTARTFILEIOERROR = 0;
            short SNREADERROR = 0;
            short SNFILECLOSEERROR = 0;
            short SNENDFILEIOERROR = 0;
            
            CrestronString SRVITEMPREADDATA__DOLLAR__;
            SRVITEMPREADDATA__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5500, this );
            
            
            __context__.SourceCodeLine = 1026;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1026;
                Trace( "***** Start ProcessRVIFile *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1027;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Processing RVI File...") ; 
            __context__.SourceCodeLine = 1029;
            SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
            __context__.SourceCodeLine = 1030;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNSTARTFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1032;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1032;
                    Trace( "Start File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1033;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 1034;
                SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
                __context__.SourceCodeLine = 1030;
                } 
            
            __context__.SourceCodeLine = 1036;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SRVIFILE__DOLLAR__ != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 1038;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1038;
                    Trace( "sRVIFile$ = {0}\r\n", SRVIFILE__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 1040;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_8__ = ((int)Functions.GetSeries());
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1044;
                            SNFILEHANDLE = (short) ( FileOpen( SRVIFILE__DOLLAR__ ,(ushort) (0 | 16384) ) ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1048;
                            SNFILEHANDLE = (short) ( FileOpenShared( SRVIFILE__DOLLAR__ ,(ushort) (0 | 16384) ) ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 1052;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1054;
                    Trace( "FileOpen Complete\r\n") ; 
                    __context__.SourceCodeLine = 1055;
                    Trace( "snFileHandle = {0:d}\r\n", (short)SNFILEHANDLE) ; 
                    } 
                
                __context__.SourceCodeLine = 1058;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SNFILEHANDLE >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1060;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FileRead( (short)( SNFILEHANDLE ) , SRVITEMPREADDATA__DOLLAR__ , (ushort)( 5000 ) ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1062;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 1062;
                            Trace( "File Read Ok\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 1063;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 1063;
                            Trace( "len(sRVITempReadData$) = {0:d}\r\n", (ushort)Functions.Length( SRVITEMPREADDATA__DOLLAR__ )) ; 
                            }
                        
                        __context__.SourceCodeLine = 1064;
                        PARSERVIFILEDATA (  __context__ , SRVITEMPREADDATA__DOLLAR__) ; 
                        __context__.SourceCodeLine = 1060;
                        } 
                    
                    __context__.SourceCodeLine = 1066;
                    SNFILECLOSEERROR = (short) ( FileClose( (short)( SNFILEHANDLE ) ) ) ; 
                    __context__.SourceCodeLine = 1067;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNFILECLOSEERROR != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1069;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 1069;
                            Trace( "File Close Error Retrying\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 1070;
                        Functions.Delay (  (int) ( 100 ) ) ; 
                        __context__.SourceCodeLine = 1071;
                        SNFILECLOSEERROR = (short) ( FileClose( (short)( SNFILEHANDLE ) ) ) ; 
                        __context__.SourceCodeLine = 1067;
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1076;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 1076;
                        Trace( "snFileHandle Error\r\n") ; 
                        }
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1079;
            SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
            __context__.SourceCodeLine = 1080;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNENDFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1082;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1082;
                    Trace( "End File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1083;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 1084;
                SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
                __context__.SourceCodeLine = 1080;
                } 
            
            __context__.SourceCodeLine = 1087;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1087;
                Trace( "***** End ProcessRVIFile *****\r\n") ; 
                }
            
            
            }
            
        private void COPYANDDELETEFILES (  SplusExecutionContext __context__, ushort NDELETEMODE ) 
            { 
            CrestronString SCONSOLECOMMAND__DOLLAR__;
            CrestronString STEMPFILENAME__DOLLAR__;
            SCONSOLECOMMAND__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 300, this );
            STEMPFILENAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            short SNSTARTFILEIOERROR = 0;
            short SNENDFILEIOERROR = 0;
            
            
            __context__.SourceCodeLine = 1096;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Connecting To Console...") ; 
            __context__.SourceCodeLine = 1098;
            G_SNCONSOLECONNECTIONOK = (short) ( Functions.SocketConnectClient( TCPCONSOLE , "127.0.0.1" , (ushort)( 41795 ) , (ushort)( 0 ) ) ) ; 
            __context__.SourceCodeLine = 1099;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1099;
                Trace( "g_snConsoleConnectionOk = {0:d}\r\n", (short)G_SNCONSOLECONNECTIONOK) ; 
                }
            
            __context__.SourceCodeLine = 1101;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SNCONSOLECONNECTIONSTATUS != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1103;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 1104;
                Functions.Delay (  (int) ( 200 ) ) ; 
                __context__.SourceCodeLine = 1101;
                } 
            
            __context__.SourceCodeLine = 1106;
            Functions.Delay (  (int) ( 1000 ) ) ; 
            __context__.SourceCodeLine = 1108;
            MakeString ( SCONSOLECOMMAND__DOLLAR__ , "\r\n") ; 
            __context__.SourceCodeLine = 1109;
            Functions.SocketSend ( TCPCONSOLE , SCONSOLECOMMAND__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 1110;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1110;
                Trace( "Console Command 1 Sent\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1111;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1111;
                Trace( "sConsoleCommand$ = {0}\r\n", SCONSOLECOMMAND__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 1112;
            Functions.Delay (  (int) ( 1000 ) ) ; 
            __context__.SourceCodeLine = 1114;
            if ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 1116;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1116;
                    Trace( "*** Full Delete Mode ***\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1117;
                MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Deleting Old RVI File...") ; 
                __context__.SourceCodeLine = 1119;
                MakeString ( SCONSOLECOMMAND__DOLLAR__ , "del {0}{1}\r\n", G_SRVIFILELOCATION__DOLLAR__ , G_SRVIFILENAME__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1120;
                Functions.SocketSend ( TCPCONSOLE , SCONSOLECOMMAND__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1121;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1121;
                    Trace( "Console Command 2 Sent\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1122;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1122;
                    Trace( "sConsoleCommand$ = {0}\r\n", SCONSOLECOMMAND__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 1123;
                Functions.Delay (  (int) ( 1000 ) ) ; 
                __context__.SourceCodeLine = 1125;
                MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Copying New RVI File...") ; 
                __context__.SourceCodeLine = 1127;
                MakeString ( SCONSOLECOMMAND__DOLLAR__ , "copy \u0022{0}{1}\u0022 \u0022{2}{3}\u0022\r\n", FILESTORAGELOCATION__DOLLAR__ , G_SRVIFILENAME__DOLLAR__ , G_SRVIFILELOCATION__DOLLAR__ , G_SRVIFILENAME__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1128;
                Functions.SocketSend ( TCPCONSOLE , SCONSOLECOMMAND__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1129;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1129;
                    Trace( "Console Command 3 Sent\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1130;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1130;
                    Trace( "sConsoleCommand$ = {0}\r\n", SCONSOLECOMMAND__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 1131;
                Functions.Delay (  (int) ( 1000 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 1134;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Deleting Temp RVI File...") ; 
            __context__.SourceCodeLine = 1136;
            SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
            __context__.SourceCodeLine = 1137;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNSTARTFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1139;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1139;
                    Trace( "Start File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1140;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 1141;
                SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
                __context__.SourceCodeLine = 1137;
                } 
            
            __context__.SourceCodeLine = 1144;
            MakeString ( STEMPFILENAME__DOLLAR__ , "{0}{1}", FILESTORAGELOCATION__DOLLAR__ , G_SRVIFILENAME__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 1145;
            FileDelete ( STEMPFILENAME__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 1147;
            SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
            __context__.SourceCodeLine = 1148;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNENDFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1150;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1150;
                    Trace( "End File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1151;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 1152;
                SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
                __context__.SourceCodeLine = 1148;
                } 
            
            __context__.SourceCodeLine = 1155;
            MakeString ( SCONSOLECOMMAND__DOLLAR__ , "del {0}{1}\r\n", FILESTORAGELOCATION__DOLLAR__ , G_SRVIFILENAME__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 1156;
            Functions.SocketSend ( TCPCONSOLE , SCONSOLECOMMAND__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 1157;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1157;
                Trace( "Console Command 4 Sent\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1158;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1158;
                Trace( "sConsoleCommand$ = {0}\r\n", SCONSOLECOMMAND__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 1159;
            Functions.Delay (  (int) ( 1000 ) ) ; 
            __context__.SourceCodeLine = 1161;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Disconnecting Console...") ; 
            __context__.SourceCodeLine = 1163;
            MakeString ( SCONSOLECOMMAND__DOLLAR__ , "bye\r\n") ; 
            __context__.SourceCodeLine = 1164;
            Functions.SocketSend ( TCPCONSOLE , SCONSOLECOMMAND__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 1165;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1165;
                Trace( "Console Command 5 Sent\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1166;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1166;
                Trace( "sConsoleCommand$ = {0}\r\n", SCONSOLECOMMAND__DOLLAR__ ) ; 
                }
            
            
            }
            
        private void CLEAR_OUTPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort NLOOPI = 0;
            
            
            __context__.SourceCodeLine = 1173;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Clearing Current Data...") ; 
            __context__.SourceCodeLine = 1175;
            if ( Functions.TestForTrue  ( ( Functions.Not( G_NMASTERGUIDOVERRIDE ))  ) ) 
                { 
                __context__.SourceCodeLine = 1177;
                MakeString ( MASTER_GUID_PREFIX_TXT__DOLLAR__ , "") ; 
                } 
            
            __context__.SourceCodeLine = 1179;
            MakeString ( RVI_FILE_NAME_TXT__DOLLAR__ , "") ; 
            __context__.SourceCodeLine = 1180;
            MakeString ( RVI_FILE_FULL_PATH_TXT__DOLLAR__ , "") ; 
            __context__.SourceCodeLine = 1182;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)30; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( NLOOPI  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NLOOPI  >= __FN_FORSTART_VAL__1) && (NLOOPI  <= __FN_FOREND_VAL__1) ) : ( (NLOOPI  <= __FN_FORSTART_VAL__1) && (NLOOPI  >= __FN_FOREND_VAL__1) ) ; NLOOPI  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1184;
                MakeString ( SYMBOL_ROOM_NAME_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1185;
                MakeString ( SYMBOL_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1186;
                MakeString ( SYMBOL_IPID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1187;
                MakeString ( SYMBOL_GUID_COUNT_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1188;
                SYMBOL_GUID_COUNT_FB [ NLOOPI]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1189;
                G_NGUIDCOUNT [ NLOOPI] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1182;
                } 
            
            __context__.SourceCodeLine = 1192;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)252; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( NLOOPI  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (NLOOPI  >= __FN_FORSTART_VAL__2) && (NLOOPI  <= __FN_FOREND_VAL__2) ) : ( (NLOOPI  <= __FN_FORSTART_VAL__2) && (NLOOPI  >= __FN_FOREND_VAL__2) ) ; NLOOPI  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 1194;
                MakeString ( SYMBOL1_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1195;
                MakeString ( SYMBOL2_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1196;
                MakeString ( SYMBOL3_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1197;
                MakeString ( SYMBOL4_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1198;
                MakeString ( SYMBOL5_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1199;
                MakeString ( SYMBOL6_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1200;
                MakeString ( SYMBOL7_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1201;
                MakeString ( SYMBOL8_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1202;
                MakeString ( SYMBOL9_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1203;
                MakeString ( SYMBOL10_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1204;
                MakeString ( SYMBOL11_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1205;
                MakeString ( SYMBOL12_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1206;
                MakeString ( SYMBOL13_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1207;
                MakeString ( SYMBOL14_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1208;
                MakeString ( SYMBOL15_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1209;
                MakeString ( SYMBOL16_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1210;
                MakeString ( SYMBOL17_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1211;
                MakeString ( SYMBOL18_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1212;
                MakeString ( SYMBOL19_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1213;
                MakeString ( SYMBOL20_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1214;
                MakeString ( SYMBOL21_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1215;
                MakeString ( SYMBOL22_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1216;
                MakeString ( SYMBOL23_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1217;
                MakeString ( SYMBOL24_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1218;
                MakeString ( SYMBOL25_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1219;
                MakeString ( SYMBOL26_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1220;
                MakeString ( SYMBOL27_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1221;
                MakeString ( SYMBOL28_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1222;
                MakeString ( SYMBOL29_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1223;
                MakeString ( SYMBOL30_SLOT_GUID_TXT__DOLLAR__ [ NLOOPI] , "") ; 
                __context__.SourceCodeLine = 1192;
                } 
            
            
            }
            
        private void UPDATEGUIDCOUNTS (  SplusExecutionContext __context__ ) 
            { 
            ushort NLOOPJ = 0;
            
            
            __context__.SourceCodeLine = 1231;
            MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Updating GUID Counts...") ; 
            __context__.SourceCodeLine = 1233;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)30; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( NLOOPJ  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NLOOPJ  >= __FN_FORSTART_VAL__1) && (NLOOPJ  <= __FN_FOREND_VAL__1) ) : ( (NLOOPJ  <= __FN_FORSTART_VAL__1) && (NLOOPJ  >= __FN_FOREND_VAL__1) ) ; NLOOPJ  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1235;
                MakeString ( SYMBOL_GUID_COUNT_TXT__DOLLAR__ [ NLOOPJ] , "{0:d}", (ushort)G_NGUIDCOUNT[ NLOOPJ ]) ; 
                __context__.SourceCodeLine = 1236;
                SYMBOL_GUID_COUNT_FB [ NLOOPJ]  .Value = (ushort) ( G_NGUIDCOUNT[ NLOOPJ ] ) ; 
                __context__.SourceCodeLine = 1233;
                } 
            
            
            }
            
        private void UPDATE_GUIDS (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SRVIFILENAME__DOLLAR__;
            SRVIFILENAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            
            __context__.SourceCodeLine = 1244;
            if ( Functions.TestForTrue  ( ( Functions.Not( UPDATE_GUIDS_BUSY_FB  .Value ))  ) ) 
                { 
                __context__.SourceCodeLine = 1246;
                UPDATE_GUIDS_BUSY_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1247;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1247;
                    Trace( "Inside if(!Update_GUIDs_Busy_fb)\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1248;
                MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "GUID Update Started...") ; 
                __context__.SourceCodeLine = 1249;
                CLEAR_OUTPUTS (  __context__  ) ; 
                __context__.SourceCodeLine = 1250;
                G_NCONSOLESTEP = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1251;
                G_NTSIDUPDATEBUSY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1252;
                MakeString ( CONSOLE_TX__DOLLAR__ , "{0}", "ver\r\n" ) ; 
                __context__.SourceCodeLine = 1253;
                while ( Functions.TestForTrue  ( ( G_NTSIDUPDATEBUSY)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1255;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 1255;
                        Trace( "Inside while(g_nTSIDUpdateBusy)\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 1256;
                    Functions.ProcessLogic ( ) ; 
                    __context__.SourceCodeLine = 1257;
                    Functions.Delay (  (int) ( 200 ) ) ; 
                    __context__.SourceCodeLine = 1253;
                    } 
                
                __context__.SourceCodeLine = 1259;
                G_NFUSIONDATASTARTED = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1260;
                G_NFUSIONSYMBOLDATASTARTED = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1261;
                G_NFUSIONSYMBOLCOUNT = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1262;
                Functions.ClearBuffer ( G_SRVITEMP__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1263;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1263;
                    Trace( "g_sRVITemp$ = {0}\r\n", G_SRVITEMP__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 1264;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1264;
                    Trace( "len(g_sRVITemp$) = {0:d}\r\n", (short)Functions.Length( G_SRVITEMP__DOLLAR__ )) ; 
                    }
                
                __context__.SourceCodeLine = 1266;
                MakeString ( SRVIFILENAME__DOLLAR__ , "{0}", FINDRVIFILE (  __context__  ) ) ; 
                __context__.SourceCodeLine = 1268;
                if ( Functions.TestForTrue  ( ( Functions.Find( "XXXXXXXX" , G_SGUIDPREFIX__DOLLAR__[ G_NFUSIONSYMBOLCOUNT ] ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1270;
                    MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "TSID Error...") ; 
                    __context__.SourceCodeLine = 1271;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 1271;
                        Trace( "TSID Error\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 1272;
                    Functions.Delay (  (int) ( 500 ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1276;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SRVIFILENAME__DOLLAR__ != "FileFoundError"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1278;
                        MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "RVI File Found Processing File...") ; 
                        __context__.SourceCodeLine = 1279;
                        MakeString ( G_SRVIFULLFILEPATH__DOLLAR__ , "{0}{1}", G_SRVIFILELOCATION__DOLLAR__ , SRVIFILENAME__DOLLAR__ ) ; 
                        __context__.SourceCodeLine = 1280;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 1280;
                            Trace( "Inside if(sRVIFileName$ != csRVIFileSearchError)\r\ng_sRVIFullFilePath$ = {0}\r\n", G_SRVIFULLFILEPATH__DOLLAR__ ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1281;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_NDEBUG == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1283;
                            
                                {
                                int __SPLS_TMPVAR__SWTCH_9__ = ((int)Functions.GetSeries());
                                
                                    { 
                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 2) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1287;
                                        PROCESSRVIFILE (  __context__ , "\\SIMPL\\Fusion GUID Updater Simple Test Pro2 10-21-2013 rev3.rvi") ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 3) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1291;
                                        PROCESSRVIFILE (  __context__ , "\\SIMPL\\App01\\ADG-PV-Room_230-140310.rvi") ; 
                                        } 
                                    
                                    } 
                                    
                                }
                                
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1297;
                            PROCESSRVIFILE (  __context__ , G_SRVIFULLFILEPATH__DOLLAR__) ; 
                            } 
                        
                        __context__.SourceCodeLine = 1300;
                        UPDATEGUIDCOUNTS (  __context__  ) ; 
                        __context__.SourceCodeLine = 1301;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( G_NRVIFILECHANGED ) && Functions.TestForTrue ( Functions.BoolToInt (PREFIXGUIDS  .Value == 1) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1303;
                            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                {
                                __context__.SourceCodeLine = 1303;
                                Trace( "Inside if(g_nRVIFileChanged && PrefixGUIDs = cnTrue)\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 1304;
                            COPYANDDELETEFILES (  __context__ , (ushort)( 1 )) ; 
                            __context__.SourceCodeLine = 1305;
                            G_NRVIFILECHANGED = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1307;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PREFIXGUIDS  .Value == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1309;
                                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                    {
                                    __context__.SourceCodeLine = 1309;
                                    Trace( "Inside ELSE if(PrefixGUIDs = cnTrue)\r\n") ; 
                                    }
                                
                                __context__.SourceCodeLine = 1310;
                                COPYANDDELETEFILES (  __context__ , (ushort)( 2 )) ; 
                                __context__.SourceCodeLine = 1311;
                                G_NRVIFILECHANGED = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1315;
                                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                                    {
                                    __context__.SourceCodeLine = 1315;
                                    Trace( "Inside ELSE if(g_nRVIFileChanged && PrefixGUIDs = cnTrue)\r\n") ; 
                                    }
                                
                                __context__.SourceCodeLine = 1316;
                                G_NRVIFILECHANGED = (ushort) ( 0 ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1321;
                        MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "RVI File Error...") ; 
                        __context__.SourceCodeLine = 1322;
                        Functions.Delay (  (int) ( 500 ) ) ; 
                        __context__.SourceCodeLine = 1323;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 1323;
                            Trace( "FindRVIFile Error\r\n") ; 
                            }
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 1326;
                MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "GUID Update Complete!") ; 
                __context__.SourceCodeLine = 1327;
                GenerateUserNotice ( "Fusion GUID Updater Completed on {0} at {1}\r\n", Functions.Date (  (int) ( 1 ) ) , Functions.Time ( ) ) ; 
                __context__.SourceCodeLine = 1328;
                UPDATE_GUIDS_BUSY_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1329;
                Functions.Delay (  (int) ( 500 ) ) ; 
                __context__.SourceCodeLine = 1330;
                MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "") ; 
                } 
            
            
            }
            
        private void CHECK_ROOMNAMES (  SplusExecutionContext __context__ ) 
            { 
            ushort NINDEX = 0;
            
            
            __context__.SourceCodeLine = 1338;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1338;
                Trace( "***** Function Check_Roomnames *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1340;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)30; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( NINDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NINDEX  >= __FN_FORSTART_VAL__1) && (NINDEX  <= __FN_FOREND_VAL__1) ) : ( (NINDEX  <= __FN_FORSTART_VAL__1) && (NINDEX  >= __FN_FOREND_VAL__1) ) ; NINDEX  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1342;
                if ( Functions.TestForTrue  ( ( G_NROOMNAMEUPDATED[ NINDEX ])  ) ) 
                    { 
                    __context__.SourceCodeLine = 1344;
                    MakeString ( G_SOVERRIDEROOMNAME__DOLLAR__ [ NINDEX ] , "{0}", OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__ [ NINDEX ] ) ; 
                    __context__.SourceCodeLine = 1345;
                    G_NROOMNAMEUPDATED [ NINDEX] = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 1340;
                } 
            
            
            }
            
        object UPDATE_GUIDS_B_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 1355;
                UPDATE_GUIDS (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object MASTER_OVERRIDE_GUID_PREFIX__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort NLOOP = 0;
            
            CrestronString STEMPNEWGUID__DOLLAR__;
            STEMPNEWGUID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 1381;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1381;
                Trace( "***** Change Master_Override_GUID_Prefix$ *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1382;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MASTER_OVERRIDE_GUID_PREFIX__DOLLAR__ != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 1384;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1384;
                    Trace( "***** Inside if(Master_Override_GUID_Prefix$ <> \u0022\u0022) *****\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1385;
                G_NMASTERGUIDOVERRIDE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1386;
                Functions.SetArray (  ref G_NGUIDOVERRIDE , (ushort)1) ; 
                __context__.SourceCodeLine = 1387;
                MakeString ( G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__ , "{0}", MASTER_OVERRIDE_GUID_PREFIX__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1388;
                MakeString ( STEMPNEWGUID__DOLLAR__ , "{0}", UPDATEGUIDPREFIX (  __context__ , G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__, (ushort)( 1000 )) ) ; 
                __context__.SourceCodeLine = 1389;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)30; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( NLOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NLOOP  >= __FN_FORSTART_VAL__1) && (NLOOP  <= __FN_FOREND_VAL__1) ) : ( (NLOOP  <= __FN_FORSTART_VAL__1) && (NLOOP  >= __FN_FOREND_VAL__1) ) ; NLOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 1391;
                    MakeString ( G_SGUIDPREFIX__DOLLAR__ [ NLOOP ] , "{0}", STEMPNEWGUID__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 1389;
                    } 
                
                __context__.SourceCodeLine = 1394;
                MakeString ( MASTER_GUID_PREFIX_TXT__DOLLAR__ , "{0}", STEMPNEWGUID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1395;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1395;
                    Trace( "sTempNewGUID$ = {0}\r\n", STEMPNEWGUID__DOLLAR__ ) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1399;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1399;
                    Trace( "***** Inside ELSE for if(Master_Override_GUID_Prefix$ <> \u0022\u0022) *****\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1400;
                G_NMASTERGUIDOVERRIDE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1401;
                Functions.SetArray (  ref G_NGUIDOVERRIDE , (ushort)0) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NLASTCHANGED = 0;
        
        
        __context__.SourceCodeLine = 1410;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1410;
            Trace( "***** Change Override_Symbol_GUID_Prefix$ *****\r\n") ; 
            }
        
        __context__.SourceCodeLine = 1412;
        NLASTCHANGED = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 1413;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1413;
            Trace( "nLastChanged = {0:d}\r\n", (ushort)NLASTCHANGED) ; 
            }
        
        __context__.SourceCodeLine = 1415;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR__[ NLASTCHANGED ] != "") ) && Functions.TestForTrue ( Functions.Not( G_NMASTERGUIDOVERRIDE ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 1417;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1417;
                Trace( "***** Inside if(Override_Symbol_GUID_Prefix$[nLastChanged] <> \u0022\u0022 && !g_nMasterGUIDOverride) *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1418;
            G_NGUIDOVERRIDE [ NLASTCHANGED] = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1419;
            MakeString ( G_SGUIDPREFIX__DOLLAR__ [ NLASTCHANGED ] , "{0}", OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR__ [ NLASTCHANGED ] ) ; 
            __context__.SourceCodeLine = 1420;
            MakeString ( G_SGUIDPREFIX__DOLLAR__ [ NLASTCHANGED ] , "{0}", UPDATEGUIDPREFIX (  __context__ , G_SGUIDPREFIX__DOLLAR__[ NLASTCHANGED ], (ushort)( NLASTCHANGED )) ) ; 
            __context__.SourceCodeLine = 1421;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1421;
                Trace( "g_sGUIDPrefix$[nLastChanged] = {0}\r\n", G_SGUIDPREFIX__DOLLAR__ [ NLASTCHANGED ] ) ; 
                }
            
            } 
        
        __context__.SourceCodeLine = 1423;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1423;
            Trace( "g_sGUIDPrefix$[nLastChanged] = {0}\r\ng_nGUIDOverride[nLastChanged] = {1:d}\r\n", G_SGUIDPREFIX__DOLLAR__ [ NLASTCHANGED ] , (short)G_NGUIDOVERRIDE[ NLASTCHANGED ]) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONSOLE_RX__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NTSIDSTARTPOS = 0;
        ushort NTSIDENDPOS = 0;
        ushort NTSIDCOUNT = 0;
        ushort NLOOP = 0;
        
        CrestronString SCONSOLESEARCHTEMP__DOLLAR__;
        CrestronString STEMPTSID__DOLLAR__;
        SCONSOLESEARCHTEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        STEMPTSID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        
        
        __context__.SourceCodeLine = 1431;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1431;
            Trace( "***** Start Console_rx$ *****\r\n") ; 
            }
        
        __context__.SourceCodeLine = 1433;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( G_NCONSOLESTEP > 0 ) ) && Functions.TestForTrue ( Functions.Find( ">" , CONSOLE_RX__DOLLAR__ ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_NTSIDRETRYCOUNT <= 5 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 1435;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "#" , CONSOLE_RX__DOLLAR__ ) ) && Functions.TestForTrue ( Functions.Find( "]" , CONSOLE_RX__DOLLAR__ ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_NCONSOLESTEP == 1) )) ) ) && Functions.TestForTrue ( Functions.Not( G_NMASTERGUIDOVERRIDE ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1437;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1437;
                    Trace( "***** Inside Console If for TSID *****\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 1438;
                NTSIDSTARTPOS = (ushort) ( (Functions.Find( "#" , CONSOLE_RX__DOLLAR__ ) + 1) ) ; 
                __context__.SourceCodeLine = 1439;
                NTSIDENDPOS = (ushort) ( Functions.Find( "]" , CONSOLE_RX__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 1440;
                NTSIDCOUNT = (ushort) ( (NTSIDENDPOS - NTSIDSTARTPOS) ) ; 
                __context__.SourceCodeLine = 1441;
                MakeString ( STEMPTSID__DOLLAR__ , "{0}", Functions.Lower ( Functions.Mid ( CONSOLE_RX__DOLLAR__ ,  (int) ( NTSIDSTARTPOS ) ,  (int) ( NTSIDCOUNT ) ) ) ) ; 
                __context__.SourceCodeLine = 1442;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1444;
                    Trace( "nTSIDStartPOS = {0:d}\r\n", (short)NTSIDSTARTPOS) ; 
                    __context__.SourceCodeLine = 1445;
                    Trace( "nTSIDEndPOS = {0:d}\r\n", (short)NTSIDENDPOS) ; 
                    __context__.SourceCodeLine = 1446;
                    Trace( "nTSIDCount = {0:d}\r\n", (short)NTSIDCOUNT) ; 
                    __context__.SourceCodeLine = 1447;
                    Trace( "sTempTSID$ = {0}\r\n", STEMPTSID__DOLLAR__ ) ; 
                    } 
                
                __context__.SourceCodeLine = 1449;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEMPTSID__DOLLAR__ ) < 8 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1451;
                    Functions.ClearBuffer ( CONSOLE_RX__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 1452;
                    G_NTSIDRETRYCOUNT = (ushort) ( (G_NTSIDRETRYCOUNT + 1) ) ; 
                    __context__.SourceCodeLine = 1453;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 1453;
                        Trace( "TSID Error, Retrying TSID, Retry Count: {0:d}\r\n", (short)G_NTSIDRETRYCOUNT) ; 
                        }
                    
                    __context__.SourceCodeLine = 1454;
                    MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "Invalid TSID Received, Retrying... Retry Count: {0:d}", (short)G_NTSIDRETRYCOUNT) ; 
                    __context__.SourceCodeLine = 1455;
                    G_NCONSOLESTEP = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1456;
                    MakeString ( CONSOLE_TX__DOLLAR__ , "{0}", "ver\r\n" ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1461;
                    G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__  .UpdateValue ( UPDATEGUIDPREFIX (  __context__ , STEMPTSID__DOLLAR__, (ushort)( 1001 ))  ) ; 
                    __context__.SourceCodeLine = 1462;
                    MakeString ( MASTER_GUID_PREFIX_TXT__DOLLAR__ , "{0}", G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 1463;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 1463;
                        Trace( "g_sGUIDMasterOverridePrefix$ = {0}\r\n", G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 1464;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)30; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( NLOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NLOOP  >= __FN_FORSTART_VAL__1) && (NLOOP  <= __FN_FOREND_VAL__1) ) : ( (NLOOP  <= __FN_FORSTART_VAL__1) && (NLOOP  >= __FN_FOREND_VAL__1) ) ; NLOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 1466;
                        if ( Functions.TestForTrue  ( ( Functions.Not( G_NGUIDOVERRIDE[ NLOOP ] ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1468;
                            MakeString ( G_SGUIDPREFIX__DOLLAR__ [ NLOOP ] , "{0}", G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__ ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 1464;
                        } 
                    
                    __context__.SourceCodeLine = 1471;
                    Functions.ClearBuffer ( CONSOLE_RX__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 1472;
                    G_NCONSOLESTEP = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1473;
                    G_NTSIDRETRYCOUNT = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1474;
                    G_NTSIDUPDATEBUSY = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1477;
                if ( Functions.TestForTrue  ( ( G_NMASTERGUIDOVERRIDE)  ) ) 
                    { 
                    __context__.SourceCodeLine = 1479;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 1479;
                        Trace( "Inside else if(g_nGUIDOverride)\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 1480;
                    Functions.ClearBuffer ( CONSOLE_RX__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 1481;
                    G_NCONSOLESTEP = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1482;
                    G_NTSIDRETRYCOUNT = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 1483;
                    G_NTSIDUPDATEBUSY = (ushort) ( 0 ) ; 
                    } 
                
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1486;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_NTSIDRETRYCOUNT > 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1488;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1488;
                    Trace( "TSID Error, Max Retries Reached, Stopping Process") ; 
                    }
                
                __context__.SourceCodeLine = 1489;
                MakeString ( UPDATE_GUID_STATUS_TXT__DOLLAR__ , "TSID Error, Max Retries Reached, Stopping Process") ; 
                __context__.SourceCodeLine = 1490;
                MakeString ( G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__ , "{0}", UPDATEGUIDPREFIX (  __context__ , "XXXXXXXX", (ushort)( 1001 )) ) ; 
                __context__.SourceCodeLine = 1491;
                MakeString ( MASTER_GUID_PREFIX_TXT__DOLLAR__ , "{0}", G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1492;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)30; 
                int __FN_FORSTEP_VAL__2 = (int)1; 
                for ( NLOOP  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (NLOOP  >= __FN_FORSTART_VAL__2) && (NLOOP  <= __FN_FOREND_VAL__2) ) : ( (NLOOP  <= __FN_FORSTART_VAL__2) && (NLOOP  >= __FN_FOREND_VAL__2) ) ; NLOOP  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 1494;
                    if ( Functions.TestForTrue  ( ( Functions.Not( G_NGUIDOVERRIDE[ NLOOP ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1496;
                        MakeString ( G_SGUIDPREFIX__DOLLAR__ [ NLOOP ] , "{0}", G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__ ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 1492;
                    } 
                
                __context__.SourceCodeLine = 1499;
                G_NTSIDUPDATEBUSY = (ushort) ( 0 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1501;
                if ( Functions.TestForTrue  ( ( Functions.Find( ">" , CONSOLE_RX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1503;
                    Functions.ClearBuffer ( CONSOLE_RX__DOLLAR__ ) ; 
                    } 
                
                }
            
            }
        
        __context__.SourceCodeLine = 1506;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1506;
            Trace( "***** End Console_rx$ *****\r\n") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NLASTROOMNAMECHANGED = 0;
        
        
        __context__.SourceCodeLine = 1513;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1513;
            Trace( "***** Change Override_Symbol_Room_Name$ *****\r\n") ; 
            }
        
        __context__.SourceCodeLine = 1515;
        NLASTROOMNAMECHANGED = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 1517;
        G_NROOMNAMEUPDATED [ NLASTROOMNAMECHANGED] = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1519;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1519;
            Trace( "nLastRoomNameChanged = {0:d}\r\n", (ushort)NLASTROOMNAMECHANGED) ; 
            }
        
        __context__.SourceCodeLine = 1520;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1520;
            Trace( "Override_Symbol_Room_Name$[nLastRoomNameChanged] = {0}\r\n", OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__ [ NLASTROOMNAMECHANGED ] ) ; 
            }
        
        __context__.SourceCodeLine = 1523;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__[ NLASTROOMNAMECHANGED ] != "") ) && Functions.TestForTrue ( G_NROOMNAMEOVERRIDEALLOWED )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 1525;
            MakeString ( G_SOVERRIDEROOMNAME__DOLLAR__ [ NLASTROOMNAMECHANGED ] , "{0}", OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__ [ NLASTROOMNAMECHANGED ] ) ; 
            __context__.SourceCodeLine = 1526;
            G_NROOMNAMEUPDATED [ NLASTROOMNAMECHANGED] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1527;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1527;
                Trace( "g_sOverrideRoomName$[nLastRoomNameChanged] = {0}\r\n", G_SOVERRIDEROOMNAME__DOLLAR__ [ NLASTROOMNAMECHANGED ] ) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TCPCONSOLE_OnSocketConnect_5 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        short SNERR = 0;
        
        
        __context__.SourceCodeLine = 1535;
        Functions.Delay (  (int) ( 200 ) ) ; 
        __context__.SourceCodeLine = 1537;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SNCONSOLECONNECTIONOK == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1539;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1539;
                Trace( "Console Socket Connection Ok\r\n") ; 
                }
            
            __context__.SourceCodeLine = 1540;
            SNERR = (short) ( Functions.SocketSend( TCPCONSOLE , "\r\n" ) ) ; 
            __context__.SourceCodeLine = 1541;
            Functions.Delay (  (int) ( 1000 ) ) ; 
            __context__.SourceCodeLine = 1542;
            SNERR = (short) ( Functions.SocketSend( TCPCONSOLE , "\r\n" ) ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1544;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SNCONSOLECONNECTIONOK != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1546;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1546;
                    Trace( "Console Socket Connection Error\r\n") ; 
                    }
                
                } 
            
            }
        
        __context__.SourceCodeLine = 1549;
        Functions.Delay (  (int) ( 200 ) ) ; 
        __context__.SourceCodeLine = 1551;
        G_SNCONSOLECONNECTIONSTATUS = (short) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object TCPCONSOLE_OnSocketDisconnect_6 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        
        __context__.SourceCodeLine = 1556;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1556;
            Trace( "***** Start socketdisconnect tcpConsole *****\r\n") ; 
            }
        
        __context__.SourceCodeLine = 1557;
        Functions.ClearBuffer ( TCPCONSOLE .  SocketRxBuf ) ; 
        __context__.SourceCodeLine = 1558;
        G_SNCONSOLECONNECTIONSTATUS = (short) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

object TCPCONSOLE_OnSocketReceive_7 ( Object __Info__ )

    { 
    SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
        ushort I = 0;
        
        CrestronString SGARBAGE__DOLLAR__;
        CrestronString STEMP__DOLLAR__;
        SGARBAGE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
        
        
        __context__.SourceCodeLine = 1566;
        if ( Functions.TestForTrue  ( ( Functions.Not( G_NSEMAPHORE ))  ) ) 
            { 
            __context__.SourceCodeLine = 1568;
            G_NSEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1570;
            STEMP__DOLLAR__  .UpdateValue ( TCPCONSOLE .  SocketRxBuf  ) ; 
            __context__.SourceCodeLine = 1572;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEMP__DOLLAR__ ) < 200 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1574;
                MakeString ( CONSOLE_STATUS_TXT__DOLLAR__ , "{0}", STEMP__DOLLAR__ ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1576;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEMP__DOLLAR__ ) >= 200 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1578;
                    MakeString ( CONSOLE_STATUS_TXT__DOLLAR__ , "{0}", Functions.Left ( STEMP__DOLLAR__ ,  (int) ( 200 ) ) ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 1580;
            Functions.ClearBuffer ( TCPCONSOLE .  SocketRxBuf ) ; 
            __context__.SourceCodeLine = 1582;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                { 
                __context__.SourceCodeLine = 1584;
                Trace( "***** Start Console Socket Receive *****\r\n") ; 
                __context__.SourceCodeLine = 1585;
                Trace( "tcpConsole.SocketRxBuf = {0}\r\n", TCPCONSOLE .  SocketRxBuf ) ; 
                __context__.SourceCodeLine = 1586;
                Trace( "sTemp$ = {0}\r\n", STEMP__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 1587;
                Trace( "Length tcpConsole.SocketRxBuf = {0:d}\r\n", (short)Functions.Length( TCPCONSOLE.SocketRxBuf )) ; 
                __context__.SourceCodeLine = 1588;
                Trace( "Length sTemp$ = {0:d}\r\n", (short)Functions.Length( STEMP__DOLLAR__ )) ; 
                __context__.SourceCodeLine = 1593;
                Trace( "*** End Console Socket Receive ***\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 1595;
            G_NSEMAPHORE = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SocketInfo__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort NCOUNT = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 1606;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 1608;
        G_NDEBUG = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1609;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1609;
            Trace( "***** Start Function Main *****\r\n") ; 
            }
        
        __context__.SourceCodeLine = 1612;
        G_SNCONSOLECONNECTIONSTATUS = (short) ( 0 ) ; 
        __context__.SourceCodeLine = 1613;
        G_NSEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1614;
        G_NCONSOLESTEP = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1615;
        G_NMASTERGUIDOVERRIDE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1616;
        Functions.SetArray (  ref G_NGUIDOVERRIDE , (ushort)0) ; 
        __context__.SourceCodeLine = 1617;
        G_NINSTANCEIDFOUND = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1618;
        G_NTSIDRETRYCOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1619;
        G_NTSIDUPDATEBUSY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1620;
        G_NRVIFILECHANGED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1621;
        G_NROOMNAMEOVERRIDEALLOWED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1623;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)30; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( NCOUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NCOUNT  >= __FN_FORSTART_VAL__1) && (NCOUNT  <= __FN_FOREND_VAL__1) ) : ( (NCOUNT  <= __FN_FORSTART_VAL__1) && (NCOUNT  >= __FN_FOREND_VAL__1) ) ; NCOUNT  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1625;
            Functions.ClearBuffer ( G_SOVERRIDEROOMNAME__DOLLAR__ [ NCOUNT ] ) ; 
            __context__.SourceCodeLine = 1623;
            } 
        
        __context__.SourceCodeLine = 1627;
        G_NROOMNAMEOVERRIDEALLOWED = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1628;
        CHECK_ROOMNAMES (  __context__  ) ; 
        __context__.SourceCodeLine = 1630;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1630;
            Trace( "***** Function Main Complete Variable Init *****\r\n") ; 
            }
        
        __context__.SourceCodeLine = 1632;
        if ( Functions.TestForTrue  ( ( PROCESSORMODE  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 1634;
            Functions.Delay (  (int) ( 12000 ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1638;
            Functions.Delay (  (int) ( 2000 ) ) ; 
            } 
        
        __context__.SourceCodeLine = 1641;
        Functions.ClearBuffer ( G_SRVINEWFILETEMP__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 1643;
        UPDATE_GUIDS (  __context__  ) ; 
        __context__.SourceCodeLine = 1645;
        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 1645;
            Trace( "***** End Function Main *****\r\n") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_NGUIDOVERRIDE  = new ushort[ 31 ];
    G_NROOMNAMEUPDATED  = new ushort[ 31 ];
    G_NGUIDCOUNT  = new ushort[ 31 ];
    G_SGUIDMASTEROVERRIDEPREFIX__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 12, this );
    G_SRVITEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5500, this );
    G_SRVINEWFILETEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5500, this );
    G_SRVIFULLFILEPATH__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    G_SRVINEWFULLFILEPATH__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    G_SRVIFILENAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    G_SRVIFILELOCATION__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    G_SGUIDPREFIX__DOLLAR__  = new CrestronString[ 31 ];
    for( uint i = 0; i < 31; i++ )
        G_SGUIDPREFIX__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 12, this );
    G_SOVERRIDEROOMNAME__DOLLAR__  = new CrestronString[ 31 ];
    for( uint i = 0; i < 31; i++ )
        G_SOVERRIDEROOMNAME__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    TCPCONSOLE  = new SplusTcpClient ( 1000, this );
    
    UPDATE_GUIDS_B = new Crestron.Logos.SplusObjects.DigitalInput( UPDATE_GUIDS_B__DigitalInput__, this );
    m_DigitalInputList.Add( UPDATE_GUIDS_B__DigitalInput__, UPDATE_GUIDS_B );
    
    UPDATE_GUIDS_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( UPDATE_GUIDS_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( UPDATE_GUIDS_BUSY_FB__DigitalOutput__, UPDATE_GUIDS_BUSY_FB );
    
    SYMBOL_GUID_COUNT_FB = new InOutArray<AnalogOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        SYMBOL_GUID_COUNT_FB[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SYMBOL_GUID_COUNT_FB__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SYMBOL_GUID_COUNT_FB__AnalogSerialOutput__ + i, SYMBOL_GUID_COUNT_FB[i+1] );
    }
    
    MASTER_OVERRIDE_GUID_PREFIX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( MASTER_OVERRIDE_GUID_PREFIX__DOLLAR____AnalogSerialInput__, 8, this );
    m_StringInputList.Add( MASTER_OVERRIDE_GUID_PREFIX__DOLLAR____AnalogSerialInput__, MASTER_OVERRIDE_GUID_PREFIX__DOLLAR__ );
    
    UPDATE_GUID_STATUS_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( UPDATE_GUID_STATUS_TXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( UPDATE_GUID_STATUS_TXT__DOLLAR____AnalogSerialOutput__, UPDATE_GUID_STATUS_TXT__DOLLAR__ );
    
    MASTER_GUID_PREFIX_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MASTER_GUID_PREFIX_TXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MASTER_GUID_PREFIX_TXT__DOLLAR____AnalogSerialOutput__, MASTER_GUID_PREFIX_TXT__DOLLAR__ );
    
    RVI_FILE_NAME_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RVI_FILE_NAME_TXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RVI_FILE_NAME_TXT__DOLLAR____AnalogSerialOutput__, RVI_FILE_NAME_TXT__DOLLAR__ );
    
    RVI_FILE_FULL_PATH_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RVI_FILE_FULL_PATH_TXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RVI_FILE_FULL_PATH_TXT__DOLLAR____AnalogSerialOutput__, RVI_FILE_FULL_PATH_TXT__DOLLAR__ );
    
    CONSOLE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, CONSOLE_TX__DOLLAR__ );
    
    CONSOLE_STATUS_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONSOLE_STATUS_TXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONSOLE_STATUS_TXT__DOLLAR____AnalogSerialOutput__, CONSOLE_STATUS_TXT__DOLLAR__ );
    
    SYMBOL_GUID_COUNT_TXT__DOLLAR__ = new InOutArray<StringOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        SYMBOL_GUID_COUNT_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL_GUID_COUNT_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL_GUID_COUNT_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL_GUID_COUNT_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL_ROOM_NAME_TXT__DOLLAR__ = new InOutArray<StringOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        SYMBOL_ROOM_NAME_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL_ROOM_NAME_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL_ROOM_NAME_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL_ROOM_NAME_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        SYMBOL_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL_IPID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        SYMBOL_IPID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL_IPID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL_IPID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL_IPID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL1_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL1_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL1_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL1_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL1_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL2_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL2_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL2_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL2_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL2_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL3_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL3_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL3_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL3_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL3_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL4_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL4_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL4_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL4_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL4_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL5_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL5_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL5_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL5_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL5_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL6_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL6_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL6_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL6_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL6_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL7_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL7_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL7_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL7_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL7_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL8_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL8_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL8_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL8_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL8_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL9_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL9_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL9_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL9_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL9_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL10_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL10_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL10_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL10_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL10_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL11_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL11_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL11_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL11_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL11_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL12_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL12_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL12_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL12_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL12_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL13_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL13_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL13_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL13_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL13_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL14_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL14_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL14_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL14_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL14_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL15_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL15_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL15_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL15_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL15_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL16_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL16_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL16_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL16_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL16_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL17_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL17_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL17_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL17_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL17_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL18_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL18_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL18_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL18_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL18_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL19_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL19_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL19_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL19_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL19_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL20_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL20_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL20_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL20_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL20_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL21_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL21_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL21_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL21_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL21_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL22_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL22_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL22_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL22_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL22_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL23_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL23_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL23_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL23_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL23_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL24_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL24_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL24_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL24_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL24_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL25_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL25_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL25_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL25_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL25_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL26_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL26_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL26_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL26_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL26_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL27_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL27_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL27_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL27_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL27_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL28_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL28_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL28_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL28_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL28_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL29_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL29_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL29_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL29_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL29_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    SYMBOL30_SLOT_GUID_TXT__DOLLAR__ = new InOutArray<StringOutput>( 252, this );
    for( uint i = 0; i < 252; i++ )
    {
        SYMBOL30_SLOT_GUID_TXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SYMBOL30_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SYMBOL30_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ + i, SYMBOL30_SLOT_GUID_TXT__DOLLAR__[i+1] );
    }
    
    CONSOLE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( CONSOLE_RX__DOLLAR____AnalogSerialInput__, 1000, this );
    m_StringInputList.Add( CONSOLE_RX__DOLLAR____AnalogSerialInput__, CONSOLE_RX__DOLLAR__ );
    
    OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__ = new InOutArray<BufferInput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.BufferInput( OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR____AnalogSerialInput__ + i, OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR____AnalogSerialInput__ + i, OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__[i+1] );
    }
    
    OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR__ = new InOutArray<BufferInput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.BufferInput( OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR____AnalogSerialInput__ + i, OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR____AnalogSerialInput__, 8, this );
        m_StringInputList.Add( OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR____AnalogSerialInput__ + i, OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR__[i+1] );
    }
    
    PROCESSORMODE = new UShortParameter( PROCESSORMODE__Parameter__, this );
    m_ParameterList.Add( PROCESSORMODE__Parameter__, PROCESSORMODE );
    
    PREFIXGUIDS = new UShortParameter( PREFIXGUIDS__Parameter__, this );
    m_ParameterList.Add( PREFIXGUIDS__Parameter__, PREFIXGUIDS );
    
    THREESERIESAPPENDSLOTNUMBER = new UShortParameter( THREESERIESAPPENDSLOTNUMBER__Parameter__, this );
    m_ParameterList.Add( THREESERIESAPPENDSLOTNUMBER__Parameter__, THREESERIESAPPENDSLOTNUMBER );
    
    FILESTORAGELOCATION__DOLLAR__ = new StringParameter( FILESTORAGELOCATION__DOLLAR____Parameter__, this );
    m_ParameterList.Add( FILESTORAGELOCATION__DOLLAR____Parameter__, FILESTORAGELOCATION__DOLLAR__ );
    
    
    UPDATE_GUIDS_B.OnDigitalPush.Add( new InputChangeHandlerWrapper( UPDATE_GUIDS_B_OnPush_0, false ) );
    MASTER_OVERRIDE_GUID_PREFIX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( MASTER_OVERRIDE_GUID_PREFIX__DOLLAR___OnChange_1, false ) );
    for( uint i = 0; i < 30; i++ )
        OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR___OnChange_2, false ) );
        
    CONSOLE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CONSOLE_RX__DOLLAR___OnChange_3, false ) );
    for( uint i = 0; i < 30; i++ )
        OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR___OnChange_4, false ) );
        
    TCPCONSOLE.OnSocketConnect.Add( new SocketHandlerWrapper( TCPCONSOLE_OnSocketConnect_5, false ) );
    TCPCONSOLE.OnSocketDisconnect.Add( new SocketHandlerWrapper( TCPCONSOLE_OnSocketDisconnect_6, false ) );
    TCPCONSOLE.OnSocketReceive.Add( new SocketHandlerWrapper( TCPCONSOLE_OnSocketReceive_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_FUSION_GUID_UPDATER_HELPER_V1_15 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint UPDATE_GUIDS_B__DigitalInput__ = 0;
const uint MASTER_OVERRIDE_GUID_PREFIX__DOLLAR____AnalogSerialInput__ = 0;
const uint CONSOLE_RX__DOLLAR____AnalogSerialInput__ = 1;
const uint OVERRIDE_SYMBOL_ROOM_NAME__DOLLAR____AnalogSerialInput__ = 2;
const uint OVERRIDE_SYMBOL_GUID_PREFIX__DOLLAR____AnalogSerialInput__ = 32;
const uint UPDATE_GUIDS_BUSY_FB__DigitalOutput__ = 0;
const uint UPDATE_GUID_STATUS_TXT__DOLLAR____AnalogSerialOutput__ = 0;
const uint MASTER_GUID_PREFIX_TXT__DOLLAR____AnalogSerialOutput__ = 1;
const uint RVI_FILE_NAME_TXT__DOLLAR____AnalogSerialOutput__ = 2;
const uint RVI_FILE_FULL_PATH_TXT__DOLLAR____AnalogSerialOutput__ = 3;
const uint CONSOLE_TX__DOLLAR____AnalogSerialOutput__ = 4;
const uint CONSOLE_STATUS_TXT__DOLLAR____AnalogSerialOutput__ = 5;
const uint SYMBOL_GUID_COUNT_FB__AnalogSerialOutput__ = 6;
const uint SYMBOL_GUID_COUNT_TXT__DOLLAR____AnalogSerialOutput__ = 36;
const uint SYMBOL_ROOM_NAME_TXT__DOLLAR____AnalogSerialOutput__ = 66;
const uint SYMBOL_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 96;
const uint SYMBOL_IPID_TXT__DOLLAR____AnalogSerialOutput__ = 126;
const uint SYMBOL1_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 156;
const uint SYMBOL2_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 408;
const uint SYMBOL3_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 660;
const uint SYMBOL4_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 912;
const uint SYMBOL5_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 1164;
const uint SYMBOL6_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 1416;
const uint SYMBOL7_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 1668;
const uint SYMBOL8_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 1920;
const uint SYMBOL9_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 2172;
const uint SYMBOL10_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 2424;
const uint SYMBOL11_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 2676;
const uint SYMBOL12_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 2928;
const uint SYMBOL13_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 3180;
const uint SYMBOL14_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 3432;
const uint SYMBOL15_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 3684;
const uint SYMBOL16_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 3936;
const uint SYMBOL17_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 4188;
const uint SYMBOL18_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 4440;
const uint SYMBOL19_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 4692;
const uint SYMBOL20_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 4944;
const uint SYMBOL21_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 5196;
const uint SYMBOL22_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 5448;
const uint SYMBOL23_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 5700;
const uint SYMBOL24_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 5952;
const uint SYMBOL25_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 6204;
const uint SYMBOL26_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 6456;
const uint SYMBOL27_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 6708;
const uint SYMBOL28_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 6960;
const uint SYMBOL29_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 7212;
const uint SYMBOL30_SLOT_GUID_TXT__DOLLAR____AnalogSerialOutput__ = 7464;
const uint PROCESSORMODE__Parameter__ = 10;
const uint PREFIXGUIDS__Parameter__ = 11;
const uint THREESERIESAPPENDSLOTNUMBER__Parameter__ = 12;
const uint FILESTORAGELOCATION__DOLLAR____Parameter__ = 13;

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
