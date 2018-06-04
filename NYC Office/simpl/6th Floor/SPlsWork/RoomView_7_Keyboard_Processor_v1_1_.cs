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

namespace UserModule_ROOMVIEW_7_KEYBOARD_PROCESSOR_V1_1_
{
    public class UserModuleClass_ROOMVIEW_7_KEYBOARD_PROCESSOR_V1_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CLEAR;
        Crestron.Logos.SplusObjects.DigitalInput BACKSPACE;
        Crestron.Logos.SplusObjects.AnalogInput MAXCHARS;
        Crestron.Logos.SplusObjects.AnalogInput KEYBOARDCHAR;
        Crestron.Logos.SplusObjects.StringInput TEXT_IN__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput STRINGLENISZERO;
        Crestron.Logos.SplusObjects.StringOutput TEXT_OUT__DOLLAR__;
        CrestronString G_STEXT;
        object CLEAR_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 124;
                G_STEXT  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 125;
                TEXT_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 126;
                STRINGLENISZERO  .Value = (ushort) ( 1 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object BACKSPACE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 132;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_STEXT ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 134;
                G_STEXT  .UpdateValue ( Functions.Left ( G_STEXT ,  (int) ( (Functions.Length( G_STEXT ) - 1) ) )  ) ; 
                __context__.SourceCodeLine = 135;
                TEXT_OUT__DOLLAR__  .UpdateValue ( G_STEXT  ) ; 
                __context__.SourceCodeLine = 137;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( G_STEXT ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 140;
                    STRINGLENISZERO  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 144;
                    STRINGLENISZERO  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object KEYBOARDCHAR_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 152;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( G_STEXT ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Chr( (int)( KEYBOARDCHAR  .UshortValue ) ) == " ") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 155;
            return  this ; 
            } 
        
        __context__.SourceCodeLine = 158;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_STEXT ) < MAXCHARS  .UshortValue ))  ) ) 
            { 
            __context__.SourceCodeLine = 160;
            G_STEXT  .UpdateValue ( G_STEXT + Functions.Chr (  (int) ( KEYBOARDCHAR  .UshortValue ) )  ) ; 
            __context__.SourceCodeLine = 161;
            TEXT_OUT__DOLLAR__  .UpdateValue ( G_STEXT  ) ; 
            __context__.SourceCodeLine = 162;
            STRINGLENISZERO  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TEXT_IN__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 168;
        G_STEXT  .UpdateValue ( TEXT_IN__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 169;
        TEXT_OUT__DOLLAR__  .UpdateValue ( G_STEXT  ) ; 
        __context__.SourceCodeLine = 171;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( G_STEXT ) == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 173;
            STRINGLENISZERO  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 177;
            STRINGLENISZERO  .Value = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 191;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 192;
        G_STEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 193;
        TEXT_OUT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_STEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR__DigitalInput__, CLEAR );
    
    BACKSPACE = new Crestron.Logos.SplusObjects.DigitalInput( BACKSPACE__DigitalInput__, this );
    m_DigitalInputList.Add( BACKSPACE__DigitalInput__, BACKSPACE );
    
    STRINGLENISZERO = new Crestron.Logos.SplusObjects.DigitalOutput( STRINGLENISZERO__DigitalOutput__, this );
    m_DigitalOutputList.Add( STRINGLENISZERO__DigitalOutput__, STRINGLENISZERO );
    
    MAXCHARS = new Crestron.Logos.SplusObjects.AnalogInput( MAXCHARS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAXCHARS__AnalogSerialInput__, MAXCHARS );
    
    KEYBOARDCHAR = new Crestron.Logos.SplusObjects.AnalogInput( KEYBOARDCHAR__AnalogSerialInput__, this );
    m_AnalogInputList.Add( KEYBOARDCHAR__AnalogSerialInput__, KEYBOARDCHAR );
    
    TEXT_IN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TEXT_IN__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( TEXT_IN__DOLLAR____AnalogSerialInput__, TEXT_IN__DOLLAR__ );
    
    TEXT_OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TEXT_OUT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TEXT_OUT__DOLLAR____AnalogSerialOutput__, TEXT_OUT__DOLLAR__ );
    
    
    CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_OnPush_0, false ) );
    BACKSPACE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BACKSPACE_OnPush_1, false ) );
    KEYBOARDCHAR.OnAnalogChange.Add( new InputChangeHandlerWrapper( KEYBOARDCHAR_OnChange_2, false ) );
    TEXT_IN__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TEXT_IN__DOLLAR___OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ROOMVIEW_7_KEYBOARD_PROCESSOR_V1_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CLEAR__DigitalInput__ = 0;
const uint BACKSPACE__DigitalInput__ = 1;
const uint MAXCHARS__AnalogSerialInput__ = 0;
const uint KEYBOARDCHAR__AnalogSerialInput__ = 1;
const uint TEXT_IN__DOLLAR____AnalogSerialInput__ = 2;
const uint STRINGLENISZERO__DigitalOutput__ = 0;
const uint TEXT_OUT__DOLLAR____AnalogSerialOutput__ = 0;

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
