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

namespace UserModule_RVSE_GENERIC_TAB_CONTROL_V1A_
{
    public class UserModuleClass_RVSE_GENERIC_TAB_CONTROL_V1A_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.AnalogOutput TAB_QTY;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SHOW_FUNCTION;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ENABLE_FUNCTION;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> TAB_LABEL_IN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> TAB_MODE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> TAB_FUNCTION_VALUE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> TAB_LABEL_OUT__DOLLAR__;
        ushort G_ITABCOUNT = 0;
        ushort [] G_ITABFUNCTIONVALUE;
        private void UPDATEOUTPUTS (  SplusExecutionContext __context__, ushort IFUNCTION ) 
            { 
            ushort I = 0;
            ushort ISHOWCOUNT = 0;
            
            
            __context__.SourceCodeLine = 102;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 104;
                Print( "\r\n** UpdateOutputs **\r\n") ; 
                __context__.SourceCodeLine = 105;
                Print( "  Function:{0:d}\r\n", (ushort)IFUNCTION) ; 
                __context__.SourceCodeLine = 106;
                Print( "  TabCount:{0:d}\r\n", (ushort)G_ITABCOUNT) ; 
                } 
            
            __context__.SourceCodeLine = 110;
            ISHOWCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 112;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFUNCTION == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 116;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 118;
                    Print( "  Update all outputs.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 121;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)G_ITABCOUNT; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 124;
                    if ( Functions.TestForTrue  ( ( SHOW_FUNCTION[ I ] .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 128;
                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 130;
                            Print( "  Show Function:{0:d}\r\n", (ushort)I) ; 
                            } 
                        
                        __context__.SourceCodeLine = 133;
                        ISHOWCOUNT = (ushort) ( (ISHOWCOUNT + 1) ) ; 
                        __context__.SourceCodeLine = 136;
                        G_ITABFUNCTIONVALUE [ ISHOWCOUNT] = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 137;
                        TAB_FUNCTION_VALUE [ ISHOWCOUNT]  .Value = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 140;
                        if ( Functions.TestForTrue  ( ( ENABLE_FUNCTION[ I ] .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 143;
                            TAB_MODE [ ISHOWCOUNT]  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 148;
                            TAB_MODE [ ISHOWCOUNT]  .Value = (ushort) ( 2 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 152;
                        TAB_LABEL_OUT__DOLLAR__ [ ISHOWCOUNT]  .UpdateValue ( TAB_LABEL_IN__DOLLAR__ [ I ]  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 121;
                    } 
                
                __context__.SourceCodeLine = 156;
                TAB_QTY  .Value = (ushort) ( ISHOWCOUNT ) ; 
                __context__.SourceCodeLine = 159;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISHOWCOUNT < G_ITABCOUNT ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 161;
                    ushort __FN_FORSTART_VAL__2 = (ushort) ( (ISHOWCOUNT + 1) ) ;
                    ushort __FN_FOREND_VAL__2 = (ushort)G_ITABCOUNT; 
                    int __FN_FORSTEP_VAL__2 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                        { 
                        __context__.SourceCodeLine = 163;
                        TAB_MODE [ I]  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 164;
                        TAB_LABEL_OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 161;
                        } 
                    
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 172;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 174;
                    Print( "  Only update tab associated with function.\r\n") ; 
                    } 
                
                __context__.SourceCodeLine = 178;
                ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__3 = (ushort)G_ITABCOUNT; 
                int __FN_FORSTEP_VAL__3 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 180;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ITABFUNCTIONVALUE[ I ] == IFUNCTION))  ) ) 
                        { 
                        __context__.SourceCodeLine = 184;
                        if ( Functions.TestForTrue  ( ( ENABLE_FUNCTION[ IFUNCTION ] .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 186;
                            TAB_MODE [ I]  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 190;
                            TAB_MODE [ I]  .Value = (ushort) ( 2 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 193;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 178;
                    } 
                
                } 
            
            
            }
            
        private void TABCOUNT (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 203;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 204;
                Print( "\r\n** TabCount **\r\n") ; 
                }
            
            __context__.SourceCodeLine = 206;
            G_ITABCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 209;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)5; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 211;
                if ( Functions.TestForTrue  ( ( IsSignalDefined( TAB_LABEL_OUT__DOLLAR__[ I ] ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 213;
                    G_ITABCOUNT = (ushort) ( (G_ITABCOUNT + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 217;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 209;
                } 
            
            __context__.SourceCodeLine = 221;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 222;
                Print( "  Tab Count:{0:d}\r\n", (ushort)G_ITABCOUNT) ; 
                }
            
            
            }
            
        object ENABLE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 234;
                TABCOUNT (  __context__  ) ; 
                __context__.SourceCodeLine = 237;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)G_ITABCOUNT; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 239;
                    TAB_MODE [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 240;
                    TAB_FUNCTION_VALUE [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 241;
                    TAB_LABEL_OUT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 237;
                    } 
                
                __context__.SourceCodeLine = 244;
                UPDATEOUTPUTS (  __context__ , (ushort)( 0 )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SHOW_FUNCTION_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 249;
            if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 250;
                UPDATEOUTPUTS (  __context__ , (ushort)( 0 )) ; 
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SHOW_FUNCTION_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 255;
        if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 256;
            UPDATEOUTPUTS (  __context__ , (ushort)( 0 )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_FUNCTION_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IINDEX = 0;
        
        
        __context__.SourceCodeLine = 265;
        if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 267;
            IINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 268;
            UPDATEOUTPUTS (  __context__ , (ushort)( IINDEX )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_FUNCTION_OnRelease_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IINDEX = 0;
        
        
        __context__.SourceCodeLine = 278;
        if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 280;
            IINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 281;
            UPDATEOUTPUTS (  __context__ , (ushort)( IINDEX )) ; 
            } 
        
        
        
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
        
        __context__.SourceCodeLine = 293;
        TAB_QTY  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_ITABFUNCTIONVALUE  = new ushort[ 6 ];
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    SHOW_FUNCTION = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        SHOW_FUNCTION[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SHOW_FUNCTION__DigitalInput__ + i, SHOW_FUNCTION__DigitalInput__, this );
        m_DigitalInputList.Add( SHOW_FUNCTION__DigitalInput__ + i, SHOW_FUNCTION[i+1] );
    }
    
    ENABLE_FUNCTION = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        ENABLE_FUNCTION[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_FUNCTION__DigitalInput__ + i, ENABLE_FUNCTION__DigitalInput__, this );
        m_DigitalInputList.Add( ENABLE_FUNCTION__DigitalInput__ + i, ENABLE_FUNCTION[i+1] );
    }
    
    TAB_QTY = new Crestron.Logos.SplusObjects.AnalogOutput( TAB_QTY__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TAB_QTY__AnalogSerialOutput__, TAB_QTY );
    
    TAB_MODE = new InOutArray<AnalogOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        TAB_MODE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( TAB_MODE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( TAB_MODE__AnalogSerialOutput__ + i, TAB_MODE[i+1] );
    }
    
    TAB_FUNCTION_VALUE = new InOutArray<AnalogOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        TAB_FUNCTION_VALUE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( TAB_FUNCTION_VALUE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( TAB_FUNCTION_VALUE__AnalogSerialOutput__ + i, TAB_FUNCTION_VALUE[i+1] );
    }
    
    TAB_LABEL_IN__DOLLAR__ = new InOutArray<StringInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        TAB_LABEL_IN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( TAB_LABEL_IN__DOLLAR____AnalogSerialInput__ + i, TAB_LABEL_IN__DOLLAR____AnalogSerialInput__, 25, this );
        m_StringInputList.Add( TAB_LABEL_IN__DOLLAR____AnalogSerialInput__ + i, TAB_LABEL_IN__DOLLAR__[i+1] );
    }
    
    TAB_LABEL_OUT__DOLLAR__ = new InOutArray<StringOutput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        TAB_LABEL_OUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( TAB_LABEL_OUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( TAB_LABEL_OUT__DOLLAR____AnalogSerialOutput__ + i, TAB_LABEL_OUT__DOLLAR__[i+1] );
    }
    
    
    ENABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_OnPush_0, false ) );
    for( uint i = 0; i < 5; i++ )
        SHOW_FUNCTION[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SHOW_FUNCTION_OnPush_1, false ) );
        
    for( uint i = 0; i < 5; i++ )
        SHOW_FUNCTION[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( SHOW_FUNCTION_OnRelease_2, false ) );
        
    for( uint i = 0; i < 5; i++ )
        ENABLE_FUNCTION[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_FUNCTION_OnPush_3, false ) );
        
    for( uint i = 0; i < 5; i++ )
        ENABLE_FUNCTION[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_FUNCTION_OnRelease_4, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE_GENERIC_TAB_CONTROL_V1A_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint ENABLE__DigitalInput__ = 1;
const uint TAB_QTY__AnalogSerialOutput__ = 0;
const uint SHOW_FUNCTION__DigitalInput__ = 2;
const uint ENABLE_FUNCTION__DigitalInput__ = 7;
const uint TAB_LABEL_IN__DOLLAR____AnalogSerialInput__ = 0;
const uint TAB_MODE__AnalogSerialOutput__ = 1;
const uint TAB_FUNCTION_VALUE__AnalogSerialOutput__ = 6;
const uint TAB_LABEL_OUT__DOLLAR____AnalogSerialOutput__ = 11;

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
