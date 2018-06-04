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

namespace UserModule_RVSE2_AVAILABLEROOMS_DATASCROLLER_V1_1_
{
    public class UserModuleClass_RVSE2_AVAILABLEROOMS_DATASCROLLER_V1_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG_PRINT_CURRENT_LIST;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_FIELD_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput FIRST_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput LAST_PAGE;
        Crestron.Logos.SplusObjects.DigitalInput PAGE_UP;
        Crestron.Logos.SplusObjects.DigitalInput PAGE_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_UP;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_SELECTION;
        Crestron.Logos.SplusObjects.DigitalInput DISABLE_CURRENT_SELECTION;
        Crestron.Logos.SplusObjects.AnalogInput ITEMS_PER_PAGE;
        Crestron.Logos.SplusObjects.BufferInput DATA_IN__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput MODULE_BUSY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SORTING_LIST_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ENABLE_SCROLL_BUTTONS_FB;
        Crestron.Logos.SplusObjects.AnalogOutput FIELD_SELECTED;
        Crestron.Logos.SplusObjects.StringOutput STATUS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PAGEOF__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FIELD_SELECTED_TEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FIELD_SELECTED_DATA1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FIELD_SELECTED_DATA2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FIELD_SELECTED_DATA3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FIELD_SELECTED_DATA4__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SELECT_FIELD;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> FIELD_MODE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> FIELD_TEXT__DOLLAR__;
        DATA [] ITEM;
        ushort G_BRXOK = 0;
        ushort G_BRECEIVINGLIST = 0;
        ushort G_IFIELDQTY = 0;
        ushort G_ITOTALITEMS = 0;
        ushort G_IREQUIREDPAGES = 0;
        ushort G_ICURRENTPAGE = 0;
        ushort G_IOFFSET = 0;
        CrestronString G_STEMPDATA;
        ushort G_IFIELDSELECTED = 0;
        ushort [] G_IFIELDINDEX;
        CrestronString G_SDATA;
        private void PROCESSLISTDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString SREMOVED;
            CrestronString SFIELDTEXT;
            CrestronString SFIELDDATA1;
            CrestronString SFIELDDATA2;
            CrestronString SFIELDDATA3;
            CrestronString SFIELDDATA4;
            SREMOVED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SFIELDTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            SFIELDDATA1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            SFIELDDATA2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            SFIELDDATA3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            SFIELDDATA4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            ushort IINDEX = 0;
            
            
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 181;
                Trace( "***ProcessListData***\r\n") ; 
                __context__.SourceCodeLine = 182;
                Trace( "sData: {0}", SDATA ) ; 
                } 
            
            __context__.SourceCodeLine = 184;
            IINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 186;
            do 
                { 
                __context__.SourceCodeLine = 188;
                SREMOVED  .UpdateValue ( Functions.Remove ( ">" , SDATA )  ) ; 
                __context__.SourceCodeLine = 190;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Item>" , SREMOVED ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 192;
                    SFIELDTEXT  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 193;
                    SFIELDDATA1  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 194;
                    SFIELDDATA2  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 195;
                    SFIELDDATA3  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 196;
                    SFIELDDATA4  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 198;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "</FieldText>" , SREMOVED ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 200;
                        SFIELDTEXT  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 12) ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 202;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "</FieldData1>" , SREMOVED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 204;
                            SFIELDDATA1  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 13) ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 206;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "</FieldData2>" , SREMOVED ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 208;
                                SFIELDDATA2  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 13) ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 210;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "</FieldData3>" , SREMOVED ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 212;
                                    SFIELDDATA3  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 13) ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 214;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "</FieldData4>" , SREMOVED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 216;
                                        SFIELDDATA4  .UpdateValue ( Functions.Left ( SREMOVED ,  (int) ( (Functions.Length( SREMOVED ) - 13) ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 218;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "</Item>" , SREMOVED ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 220;
                                            IINDEX = (ushort) ( (IINDEX + 1) ) ; 
                                            __context__.SourceCodeLine = 222;
                                            ITEM [ IINDEX] . BDISABLED = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 223;
                                            ITEM [ IINDEX] . FIELDTEXT  .UpdateValue ( SFIELDTEXT  ) ; 
                                            __context__.SourceCodeLine = 224;
                                            ITEM [ IINDEX] . FIELDDATA1  .UpdateValue ( SFIELDDATA1  ) ; 
                                            __context__.SourceCodeLine = 225;
                                            ITEM [ IINDEX] . FIELDDATA2  .UpdateValue ( SFIELDDATA2  ) ; 
                                            __context__.SourceCodeLine = 226;
                                            ITEM [ IINDEX] . FIELDDATA3  .UpdateValue ( SFIELDDATA3  ) ; 
                                            __context__.SourceCodeLine = 227;
                                            ITEM [ IINDEX] . FIELDDATA4  .UpdateValue ( SFIELDDATA4  ) ; 
                                            } 
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Length( SDATA ) == 0)) )); 
            __context__.SourceCodeLine = 231;
            G_ITOTALITEMS = (ushort) ( IINDEX ) ; 
            
            }
            
        private void CLEARFIELDS (  SplusExecutionContext __context__, ushort ISTARTINDEX ) 
            { 
            ushort I = 0;
            ushort IINDEX = 0;
            
            
            __context__.SourceCodeLine = 240;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 242;
                Trace( "\r\n** ClearFields **\r\n") ; 
                __context__.SourceCodeLine = 243;
                Trace( "  StartIndex:{0:d}\r\n", (ushort)ISTARTINDEX) ; 
                } 
            
            __context__.SourceCodeLine = 246;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( ISTARTINDEX ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)ITEMS_PER_PAGE  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 248;
                FIELD_TEXT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 249;
                G_IFIELDINDEX [ I] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 251;
                FIELD_MODE [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 246;
                } 
            
            
            }
            
        private void UPDATEFIELDS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            ushort IINDEX = 0;
            ushort ILASTACTIVEFIELD = 0;
            
            ushort IFIELDINDEX = 0;
            
            ushort BDISABLED = 0;
            
            
            __context__.SourceCodeLine = 266;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 267;
                Trace( "\r\n** UpdateFields **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 269;
            ILASTACTIVEFIELD = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 272;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IREQUIREDPAGES == 1))  ) ) 
                {
                __context__.SourceCodeLine = 273;
                PAGEOF__DOLLAR__  .UpdateValue ( "1 of 1"  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 275;
                PAGEOF__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( G_ICURRENTPAGE ) ) + " of " + Functions.ItoA (  (int) ( G_IREQUIREDPAGES ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 278;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IREQUIREDPAGES > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 279;
                G_IOFFSET = (ushort) ( ((G_ICURRENTPAGE * ITEMS_PER_PAGE  .UshortValue) - (ITEMS_PER_PAGE  .UshortValue - 1)) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 281;
                G_IOFFSET = (ushort) ( 1 ) ; 
                }
            
            __context__.SourceCodeLine = 283;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 285;
                Trace( "   Offset:{0:d}\r\n", (ushort)G_IOFFSET) ; 
                } 
            
            __context__.SourceCodeLine = 288;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)ITEMS_PER_PAGE  .UshortValue; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 290;
                IINDEX = (ushort) ( ((I - 1) + G_IOFFSET) ) ; 
                __context__.SourceCodeLine = 292;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IINDEX <= G_ITOTALITEMS ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 294;
                    BDISABLED = (ushort) ( ITEM[ IINDEX ].BDISABLED ) ; 
                    __context__.SourceCodeLine = 296;
                    FIELD_TEXT__DOLLAR__ [ I]  .UpdateValue ( ITEM [ IINDEX] . FIELDTEXT  ) ; 
                    __context__.SourceCodeLine = 297;
                    G_IFIELDINDEX [ I] = (ushort) ( IINDEX ) ; 
                    __context__.SourceCodeLine = 300;
                    if ( Functions.TestForTrue  ( ( ENABLE_FIELD_SELECT  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 305;
                        if ( Functions.TestForTrue  ( ( Functions.Not( BDISABLED ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 308;
                            FIELD_MODE [ I]  .Value = (ushort) ( 2 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 313;
                            FIELD_MODE [ I]  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 319;
                        FIELD_MODE [ I]  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 322;
                    ILASTACTIVEFIELD = (ushort) ( I ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 326;
                    FIELD_MODE [ I]  .Value = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 288;
                } 
            
            __context__.SourceCodeLine = 330;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 331;
                Trace( "   Last Active Field:{0:d}\r\n", (ushort)ILASTACTIVEFIELD) ; 
                }
            
            __context__.SourceCodeLine = 334;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILASTACTIVEFIELD != ITEMS_PER_PAGE  .UshortValue))  ) ) 
                {
                __context__.SourceCodeLine = 335;
                CLEARFIELDS (  __context__ , (ushort)( (ILASTACTIVEFIELD + 1) )) ; 
                }
            
            
            }
            
        private void PROCESSCOMMANDDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            
            __context__.SourceCodeLine = 341;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 342;
                Trace( "\r\n** ProcessCommandData **\r\n") ; 
                }
            
            
            }
            
        private void SETNEXTVALIDFIELD (  SplusExecutionContext __context__, ushort IDIRECTION ) 
            { 
            ushort I = 0;
            ushort ISTARTINDEX = 0;
            ushort ICURRENTFIELDINDEX = 0;
            ushort INEXTVALIDINDEX = 0;
            ushort INEEDEDPAGE = 0;
            ushort IPAGESTARTINDEX = 0;
            
            
            __context__.SourceCodeLine = 354;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 356;
                Trace( "\r\n** SetNextValidField **\r\n") ; 
                __context__.SourceCodeLine = 357;
                Trace( "  Direction:{0:d}\r\n", (ushort)IDIRECTION) ; 
                } 
            
            __context__.SourceCodeLine = 360;
            INEXTVALIDINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 361;
            INEEDEDPAGE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 362;
            IPAGESTARTINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 365;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_IFIELDSELECTED > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 367;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 368;
                    Trace( "  Current field selected:{0:d}\r\n", (ushort)G_IFIELDSELECTED) ; 
                    }
                
                __context__.SourceCodeLine = 372;
                ICURRENTFIELDINDEX = (ushort) ( G_IFIELDINDEX[ G_IFIELDSELECTED ] ) ; 
                __context__.SourceCodeLine = 374;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 376;
                    Trace( "  CurrentFieldIndex:{0:d}\r\n", (ushort)ICURRENTFIELDINDEX) ; 
                    } 
                
                __context__.SourceCodeLine = 379;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIRECTION == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 384;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTFIELDINDEX > 1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 388;
                        ISTARTINDEX = (ushort) ( (ICURRENTFIELDINDEX - 1) ) ; 
                        __context__.SourceCodeLine = 391;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( ISTARTINDEX ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)1; 
                        int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 393;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( ITEM[ I ].FIELDTEXT ) > 0 ) ) && Functions.TestForTrue ( Functions.Not( ITEM[ I ].BDISABLED ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 395;
                                INEXTVALIDINDEX = (ushort) ( I ) ; 
                                __context__.SourceCodeLine = 396;
                                break ; 
                                } 
                            
                            __context__.SourceCodeLine = 391;
                            } 
                        
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 407;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTFIELDINDEX < G_ITOTALITEMS ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 411;
                        ISTARTINDEX = (ushort) ( (ICURRENTFIELDINDEX + 1) ) ; 
                        __context__.SourceCodeLine = 414;
                        ushort __FN_FORSTART_VAL__2 = (ushort) ( ISTARTINDEX ) ;
                        ushort __FN_FOREND_VAL__2 = (ushort)G_ITOTALITEMS; 
                        int __FN_FORSTEP_VAL__2 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                            { 
                            __context__.SourceCodeLine = 416;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( ITEM[ I ].FIELDTEXT ) > 0 ) ) && Functions.TestForTrue ( Functions.Not( ITEM[ I ].BDISABLED ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 418;
                                INEXTVALIDINDEX = (ushort) ( I ) ; 
                                __context__.SourceCodeLine = 419;
                                break ; 
                                } 
                            
                            __context__.SourceCodeLine = 414;
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 426;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTVALIDINDEX > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 430;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 432;
                        Trace( "  Have valid index:{0:d}\r\n", (ushort)INEXTVALIDINDEX) ; 
                        } 
                    
                    __context__.SourceCodeLine = 436;
                    INEEDEDPAGE = (ushort) ( (((INEXTVALIDINDEX - 1) / ITEMS_PER_PAGE  .UshortValue) + 1) ) ; 
                    __context__.SourceCodeLine = 439;
                    IPAGESTARTINDEX = (ushort) ( (((INEEDEDPAGE - 1) * ITEMS_PER_PAGE  .UshortValue) + 1) ) ; 
                    __context__.SourceCodeLine = 441;
                    G_IFIELDSELECTED = (ushort) ( ((INEXTVALIDINDEX - IPAGESTARTINDEX) + 1) ) ; 
                    __context__.SourceCodeLine = 442;
                    FIELD_SELECTED  .Value = (ushort) ( G_IFIELDSELECTED ) ; 
                    __context__.SourceCodeLine = 444;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 446;
                        Trace( "  NeededPage:{0:d}\r\n", (ushort)INEEDEDPAGE) ; 
                        __context__.SourceCodeLine = 447;
                        Trace( "  PageStartIndex:{0:d}\r\n", (ushort)IPAGESTARTINDEX) ; 
                        __context__.SourceCodeLine = 448;
                        Trace( "  FieldSelected:{0:d}\r\n", (ushort)G_IFIELDSELECTED) ; 
                        } 
                    
                    __context__.SourceCodeLine = 452;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INEEDEDPAGE != G_ICURRENTPAGE))  ) ) 
                        { 
                        __context__.SourceCodeLine = 456;
                        G_ICURRENTPAGE = (ushort) ( INEEDEDPAGE ) ; 
                        __context__.SourceCodeLine = 458;
                        UPDATEFIELDS (  __context__  ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 463;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 465;
                        Trace( "  Do not have valid index\r\n") ; 
                        } 
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 473;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 474;
                    Trace( " No field selected yet.\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 476;
                G_IFIELDSELECTED = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 477;
                FIELD_SELECTED  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            }
            
        private void PROCESSDATAIN__DOLLAR__ (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            
            __context__.SourceCodeLine = 483;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 485;
                Trace( "\r\n** ProcessDataIn$ **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 488;
            MODULE_BUSY_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 490;
            if ( Functions.TestForTrue  ( ( Functions.Find( "<Type>List</Type>" , SDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 492;
                PROCESSLISTDATA (  __context__ , SDATA) ; 
                __context__.SourceCodeLine = 494;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 495;
                    Trace( "**Total Items Stored:{0:d} **\r\n", (ushort)G_ITOTALITEMS) ; 
                    }
                
                __context__.SourceCodeLine = 498;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ITOTALITEMS > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 500;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ITOTALITEMS <= ITEMS_PER_PAGE  .UshortValue ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 502;
                        G_IREQUIREDPAGES = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 506;
                        G_IREQUIREDPAGES = (ushort) ( (G_ITOTALITEMS / ITEMS_PER_PAGE  .UshortValue) ) ; 
                        __context__.SourceCodeLine = 508;
                        if ( Functions.TestForTrue  ( ( Mod( G_ITOTALITEMS , ITEMS_PER_PAGE  .UshortValue ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 510;
                            G_IREQUIREDPAGES = (ushort) ( (G_IREQUIREDPAGES + 1) ) ; 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 514;
                    G_ICURRENTPAGE = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 515;
                    G_IFIELDSELECTED = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 516;
                    FIELD_SELECTED  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 519;
                    UPDATEFIELDS (  __context__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 523;
                    G_IREQUIREDPAGES = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 524;
                    G_ICURRENTPAGE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 525;
                    G_IFIELDSELECTED = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 526;
                    FIELD_SELECTED  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 530;
                if ( Functions.TestForTrue  ( ( Functions.Find( "<Type>Command</Type>" , SDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 532;
                    PROCESSCOMMANDDATA (  __context__ , SDATA) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 535;
            MODULE_BUSY_FB  .Value = (ushort) ( 0 ) ; 
            
            }
            
        object DEBUG_PRINT_CURRENT_LIST_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 548;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)G_ITOTALITEMS; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 550;
                    Trace( "FieldText:{0}\r\n", ITEM [ I] . FIELDTEXT ) ; 
                    __context__.SourceCodeLine = 551;
                    Trace( "FieldData1:{0}\r\n", ITEM [ I] . FIELDDATA1 ) ; 
                    __context__.SourceCodeLine = 552;
                    Trace( "FieldData2:{0}\r\n", ITEM [ I] . FIELDDATA2 ) ; 
                    __context__.SourceCodeLine = 553;
                    Trace( "FieldData3:{0}\r\n", ITEM [ I] . FIELDDATA3 ) ; 
                    __context__.SourceCodeLine = 554;
                    Trace( "FieldData4:{0}\r\n", ITEM [ I] . FIELDDATA4 ) ; 
                    __context__.SourceCodeLine = 555;
                    Trace( "Disabled:{0:d}\r\n", (ushort)ITEM[ I ].BDISABLED) ; 
                    __context__.SourceCodeLine = 548;
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ENABLE_FIELD_SELECT_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 561;
            UPDATEFIELDS (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ENABLE_FIELD_SELECT_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 566;
        UPDATEFIELDS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FIRST_PAGE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 571;
        G_ICURRENTPAGE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 573;
        UPDATEFIELDS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LAST_PAGE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 578;
        G_ICURRENTPAGE = (ushort) ( G_IREQUIREDPAGES ) ; 
        __context__.SourceCodeLine = 580;
        UPDATEFIELDS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGE_UP_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 585;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTPAGE > 1 ))  ) ) 
            {
            __context__.SourceCodeLine = 586;
            G_ICURRENTPAGE = (ushort) ( (G_ICURRENTPAGE - 1) ) ; 
            }
        
        __context__.SourceCodeLine = 588;
        UPDATEFIELDS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGE_DOWN_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 593;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ICURRENTPAGE < G_IREQUIREDPAGES ))  ) ) 
            {
            __context__.SourceCodeLine = 594;
            G_ICURRENTPAGE = (ushort) ( (G_ICURRENTPAGE + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 596;
        UPDATEFIELDS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_UP_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 601;
        if ( Functions.TestForTrue  ( ( ENABLE_FIELD_SELECT  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 602;
            SETNEXTVALIDFIELD (  __context__ , (ushort)( 0 )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DOWN_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 607;
        if ( Functions.TestForTrue  ( ( ENABLE_FIELD_SELECT  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 608;
            SETNEXTVALIDFIELD (  __context__ , (ushort)( 1 )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_SELECT_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IFIELDINDEX = 0;
        
        
        __context__.SourceCodeLine = 615;
        if ( Functions.TestForTrue  ( ( ENABLE_FIELD_SELECT  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 617;
            IFIELDINDEX = (ushort) ( G_IFIELDINDEX[ G_IFIELDSELECTED ] ) ; 
            __context__.SourceCodeLine = 620;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( ITEM[ IFIELDINDEX ].FIELDTEXT ) > 0 ) ) && Functions.TestForTrue ( Functions.Not( ITEM[ IFIELDINDEX ].BDISABLED ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 622;
                FIELD_SELECTED_TEXT__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDTEXT  ) ; 
                __context__.SourceCodeLine = 623;
                FIELD_SELECTED_DATA1__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDDATA1  ) ; 
                __context__.SourceCodeLine = 624;
                FIELD_SELECTED_DATA2__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDDATA2  ) ; 
                __context__.SourceCodeLine = 625;
                FIELD_SELECTED_DATA3__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDDATA3  ) ; 
                __context__.SourceCodeLine = 626;
                FIELD_SELECTED_DATA4__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDDATA4  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEAR_SELECTION_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 633;
        G_IFIELDSELECTED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 634;
        FIELD_SELECTED  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 636;
        FIELD_SELECTED_TEXT__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 637;
        FIELD_SELECTED_DATA1__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 638;
        FIELD_SELECTED_DATA2__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 639;
        FIELD_SELECTED_DATA3__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 640;
        FIELD_SELECTED_DATA4__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISABLE_CURRENT_SELECTION_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IFIELDINDEX = 0;
        
        CrestronString SFIELDTEXT;
        SFIELDTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        
        
        __context__.SourceCodeLine = 649;
        IFIELDINDEX = (ushort) ( G_IFIELDINDEX[ G_IFIELDSELECTED ] ) ; 
        __context__.SourceCodeLine = 651;
        ITEM [ IFIELDINDEX] . BDISABLED = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 654;
        SFIELDTEXT  .UpdateValue ( Functions.Remove ( "\r" , ITEM [ IFIELDINDEX] . FIELDTEXT )  ) ; 
        __context__.SourceCodeLine = 655;
        SFIELDTEXT  .UpdateValue ( SFIELDTEXT + " - Reserved: Not Available"  ) ; 
        __context__.SourceCodeLine = 658;
        ITEM [ IFIELDINDEX] . FIELDTEXT  .UpdateValue ( SFIELDTEXT  ) ; 
        __context__.SourceCodeLine = 660;
        UPDATEFIELDS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_FIELD_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IINDEX = 0;
        ushort IFIELDINDEX = 0;
        
        
        __context__.SourceCodeLine = 667;
        IINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 669;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FIELD_MODE[ IINDEX ] .Value == 2))  ) ) 
            { 
            __context__.SourceCodeLine = 672;
            IFIELDINDEX = (ushort) ( G_IFIELDINDEX[ IINDEX ] ) ; 
            __context__.SourceCodeLine = 674;
            G_IFIELDSELECTED = (ushort) ( IINDEX ) ; 
            __context__.SourceCodeLine = 675;
            FIELD_SELECTED  .Value = (ushort) ( IINDEX ) ; 
            __context__.SourceCodeLine = 677;
            FIELD_SELECTED_TEXT__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDTEXT  ) ; 
            __context__.SourceCodeLine = 678;
            FIELD_SELECTED_DATA1__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDDATA1  ) ; 
            __context__.SourceCodeLine = 679;
            FIELD_SELECTED_DATA2__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDDATA2  ) ; 
            __context__.SourceCodeLine = 680;
            FIELD_SELECTED_DATA3__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDDATA3  ) ; 
            __context__.SourceCodeLine = 681;
            FIELD_SELECTED_DATA4__DOLLAR__  .UpdateValue ( ITEM [ IFIELDINDEX] . FIELDDATA4  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DATA_IN__DOLLAR___OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 691;
        if ( Functions.TestForTrue  ( ( G_BRXOK)  ) ) 
            { 
            __context__.SourceCodeLine = 693;
            G_BRXOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 695;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 697;
                G_SDATA  .UpdateValue ( Functions.Gather ( "</Data>" , DATA_IN__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 699;
                PROCESSDATAIN__DOLLAR__ (  __context__ , G_SDATA) ; 
                __context__.SourceCodeLine = 695;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 714;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 716;
        G_BRXOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 717;
        G_BRECEIVINGLIST = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 719;
        G_SDATA  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 721;
        G_ITOTALITEMS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 722;
        G_IREQUIREDPAGES = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 724;
        ENABLE_SCROLL_BUTTONS_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 727;
        CLEARFIELDS (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_IFIELDINDEX  = new ushort[ 26 ];
    G_STEMPDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    G_SDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 65000, this );
    ITEM  = new DATA[ 201 ];
    for( uint i = 0; i < 201; i++ )
    {
        ITEM [i] = new DATA( this, true );
        ITEM [i].PopulateCustomAttributeList( false );
        
    }
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    DEBUG_PRINT_CURRENT_LIST = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG_PRINT_CURRENT_LIST__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG_PRINT_CURRENT_LIST__DigitalInput__, DEBUG_PRINT_CURRENT_LIST );
    
    ENABLE_FIELD_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_FIELD_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_FIELD_SELECT__DigitalInput__, ENABLE_FIELD_SELECT );
    
    FIRST_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( FIRST_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( FIRST_PAGE__DigitalInput__, FIRST_PAGE );
    
    LAST_PAGE = new Crestron.Logos.SplusObjects.DigitalInput( LAST_PAGE__DigitalInput__, this );
    m_DigitalInputList.Add( LAST_PAGE__DigitalInput__, LAST_PAGE );
    
    PAGE_UP = new Crestron.Logos.SplusObjects.DigitalInput( PAGE_UP__DigitalInput__, this );
    m_DigitalInputList.Add( PAGE_UP__DigitalInput__, PAGE_UP );
    
    PAGE_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( PAGE_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( PAGE_DOWN__DigitalInput__, PAGE_DOWN );
    
    SELECT_UP = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_UP__DigitalInput__, SELECT_UP );
    
    SELECT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DOWN__DigitalInput__, SELECT_DOWN );
    
    SELECT_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_SELECT__DigitalInput__, SELECT_SELECT );
    
    CLEAR_SELECTION = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_SELECTION__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_SELECTION__DigitalInput__, CLEAR_SELECTION );
    
    DISABLE_CURRENT_SELECTION = new Crestron.Logos.SplusObjects.DigitalInput( DISABLE_CURRENT_SELECTION__DigitalInput__, this );
    m_DigitalInputList.Add( DISABLE_CURRENT_SELECTION__DigitalInput__, DISABLE_CURRENT_SELECTION );
    
    SELECT_FIELD = new InOutArray<DigitalInput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        SELECT_FIELD[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_FIELD__DigitalInput__ + i, SELECT_FIELD__DigitalInput__, this );
        m_DigitalInputList.Add( SELECT_FIELD__DigitalInput__ + i, SELECT_FIELD[i+1] );
    }
    
    MODULE_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MODULE_BUSY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MODULE_BUSY_FB__DigitalOutput__, MODULE_BUSY_FB );
    
    SORTING_LIST_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SORTING_LIST_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SORTING_LIST_FB__DigitalOutput__, SORTING_LIST_FB );
    
    ENABLE_SCROLL_BUTTONS_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ENABLE_SCROLL_BUTTONS_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENABLE_SCROLL_BUTTONS_FB__DigitalOutput__, ENABLE_SCROLL_BUTTONS_FB );
    
    ITEMS_PER_PAGE = new Crestron.Logos.SplusObjects.AnalogInput( ITEMS_PER_PAGE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ITEMS_PER_PAGE__AnalogSerialInput__, ITEMS_PER_PAGE );
    
    FIELD_SELECTED = new Crestron.Logos.SplusObjects.AnalogOutput( FIELD_SELECTED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FIELD_SELECTED__AnalogSerialOutput__, FIELD_SELECTED );
    
    FIELD_MODE = new InOutArray<AnalogOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        FIELD_MODE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( FIELD_MODE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( FIELD_MODE__AnalogSerialOutput__ + i, FIELD_MODE[i+1] );
    }
    
    STATUS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( STATUS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( STATUS__DOLLAR____AnalogSerialOutput__, STATUS__DOLLAR__ );
    
    PAGEOF__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PAGEOF__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PAGEOF__DOLLAR____AnalogSerialOutput__, PAGEOF__DOLLAR__ );
    
    FIELD_SELECTED_TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FIELD_SELECTED_TEXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FIELD_SELECTED_TEXT__DOLLAR____AnalogSerialOutput__, FIELD_SELECTED_TEXT__DOLLAR__ );
    
    FIELD_SELECTED_DATA1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FIELD_SELECTED_DATA1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FIELD_SELECTED_DATA1__DOLLAR____AnalogSerialOutput__, FIELD_SELECTED_DATA1__DOLLAR__ );
    
    FIELD_SELECTED_DATA2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FIELD_SELECTED_DATA2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FIELD_SELECTED_DATA2__DOLLAR____AnalogSerialOutput__, FIELD_SELECTED_DATA2__DOLLAR__ );
    
    FIELD_SELECTED_DATA3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FIELD_SELECTED_DATA3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FIELD_SELECTED_DATA3__DOLLAR____AnalogSerialOutput__, FIELD_SELECTED_DATA3__DOLLAR__ );
    
    FIELD_SELECTED_DATA4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FIELD_SELECTED_DATA4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FIELD_SELECTED_DATA4__DOLLAR____AnalogSerialOutput__, FIELD_SELECTED_DATA4__DOLLAR__ );
    
    FIELD_TEXT__DOLLAR__ = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        FIELD_TEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( FIELD_TEXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( FIELD_TEXT__DOLLAR____AnalogSerialOutput__ + i, FIELD_TEXT__DOLLAR__[i+1] );
    }
    
    DATA_IN__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DATA_IN__DOLLAR____AnalogSerialInput__, 65000, this );
    m_StringInputList.Add( DATA_IN__DOLLAR____AnalogSerialInput__, DATA_IN__DOLLAR__ );
    
    
    DEBUG_PRINT_CURRENT_LIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( DEBUG_PRINT_CURRENT_LIST_OnPush_0, false ) );
    ENABLE_FIELD_SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_FIELD_SELECT_OnPush_1, false ) );
    ENABLE_FIELD_SELECT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_FIELD_SELECT_OnRelease_2, false ) );
    FIRST_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FIRST_PAGE_OnPush_3, false ) );
    LAST_PAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LAST_PAGE_OnPush_4, false ) );
    PAGE_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAGE_UP_OnPush_5, false ) );
    PAGE_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAGE_DOWN_OnPush_6, false ) );
    SELECT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_UP_OnPush_7, false ) );
    SELECT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DOWN_OnPush_8, false ) );
    SELECT_SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_SELECT_OnPush_9, false ) );
    CLEAR_SELECTION.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_SELECTION_OnPush_10, false ) );
    DISABLE_CURRENT_SELECTION.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISABLE_CURRENT_SELECTION_OnPush_11, false ) );
    for( uint i = 0; i < 25; i++ )
        SELECT_FIELD[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_FIELD_OnPush_12, false ) );
        
    DATA_IN__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DATA_IN__DOLLAR___OnChange_13, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE2_AVAILABLEROOMS_DATASCROLLER_V1_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint DEBUG_PRINT_CURRENT_LIST__DigitalInput__ = 1;
const uint ENABLE_FIELD_SELECT__DigitalInput__ = 2;
const uint FIRST_PAGE__DigitalInput__ = 3;
const uint LAST_PAGE__DigitalInput__ = 4;
const uint PAGE_UP__DigitalInput__ = 5;
const uint PAGE_DOWN__DigitalInput__ = 6;
const uint SELECT_UP__DigitalInput__ = 7;
const uint SELECT_DOWN__DigitalInput__ = 8;
const uint SELECT_SELECT__DigitalInput__ = 9;
const uint CLEAR_SELECTION__DigitalInput__ = 10;
const uint DISABLE_CURRENT_SELECTION__DigitalInput__ = 11;
const uint ITEMS_PER_PAGE__AnalogSerialInput__ = 0;
const uint DATA_IN__DOLLAR____AnalogSerialInput__ = 1;
const uint MODULE_BUSY_FB__DigitalOutput__ = 0;
const uint SORTING_LIST_FB__DigitalOutput__ = 1;
const uint ENABLE_SCROLL_BUTTONS_FB__DigitalOutput__ = 2;
const uint FIELD_SELECTED__AnalogSerialOutput__ = 0;
const uint STATUS__DOLLAR____AnalogSerialOutput__ = 1;
const uint PAGEOF__DOLLAR____AnalogSerialOutput__ = 2;
const uint FIELD_SELECTED_TEXT__DOLLAR____AnalogSerialOutput__ = 3;
const uint FIELD_SELECTED_DATA1__DOLLAR____AnalogSerialOutput__ = 4;
const uint FIELD_SELECTED_DATA2__DOLLAR____AnalogSerialOutput__ = 5;
const uint FIELD_SELECTED_DATA3__DOLLAR____AnalogSerialOutput__ = 6;
const uint FIELD_SELECTED_DATA4__DOLLAR____AnalogSerialOutput__ = 7;
const uint SELECT_FIELD__DigitalInput__ = 12;
const uint FIELD_MODE__AnalogSerialOutput__ = 8;
const uint FIELD_TEXT__DOLLAR____AnalogSerialOutput__ = 33;

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

[SplusStructAttribute(-1, true, false)]
public class DATA : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  BDISABLED = 0;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  FIELDTEXT;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  FIELDDATA1;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  FIELDDATA2;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  FIELDDATA3;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  FIELDDATA4;
    
    
    public DATA( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        FIELDTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, Owner );
        FIELDDATA1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, Owner );
        FIELDDATA2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, Owner );
        FIELDDATA3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, Owner );
        FIELDDATA4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, Owner );
        
        
    }
    
}

}
