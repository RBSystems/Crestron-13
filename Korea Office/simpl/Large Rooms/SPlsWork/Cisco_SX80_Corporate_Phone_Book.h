namespace Cisco_SX80_Corporate_Phone_Book;
        // class declarations
         class Corporate_Phone_Book;
         class eConferenceCallRate;
         class eConferenceCallProtocol;
         class eConferenceCallType;
         class ePhoneBookContactType;
         class ePhoneBookLocation;
         class Contact;
         class MethodOfContact;
         class Searches;
     class Corporate_Phone_Book 
    {
        // class delegates
        delegate FUNCTION delegateCommndToSendChange ( SIMPLSHARPSTRING toSimplPlus );
        delegate FUNCTION delegateClearSearchComplete ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateCurrentLevel ( SIGNED_LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateNumberOfResultsChange ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateSearchComplete ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateSearchPathBarChange ( SIMPLSHARPSTRING toSimplPlus );
        delegate FUNCTION delegateSelectedItemChange ( SIGNED_LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateUpOneLevelComplete ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delgateSearchStringChange ( SIMPLSHARPSTRING toSimplPlus );
        delegate FUNCTION delegateDialError ( SIMPLSHARPSTRING toSimplPlus );
        delegate FUNCTION delegateSearchItemType ( SIMPLSHARPSTRING toSimplPlus );
        delegate FUNCTION delegateTopComplete ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateSelectedItemName ( SIMPLSHARPSTRING toSimplPlus );
        delegate FUNCTION delegateSelectedItemNumber ( SIMPLSHARPSTRING toSimplPlus );
        delegate FUNCTION delegateTotalResults ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateResultsDisplayRange ( SIMPLSHARPSTRING toSimplPlus );

        // class events

        // class functions
        FUNCTION cisco_sendCommand ( STRING simplString );
        FUNCTION cisco_searchClearComplete ( LONG_INTEGER simplValue );
        FUNCTION cisco_currentLevel ( SIGNED_LONG_INTEGER simplValue );
        FUNCTION cisco_numberOfResults ( LONG_INTEGER simplValue );
        FUNCTION cisco_searchComplete ( LONG_INTEGER simplValue );
        FUNCTION cisco_searchPathBar ( STRING simplString );
        FUNCTION cisco_selectedItem ( SIGNED_LONG_INTEGER simplValue );
        FUNCTION cisco_upOneLevel ( LONG_INTEGER simplValue );
        FUNCTION cisco_searchString ( STRING simplString );
        FUNCTION cisco_dialError ( STRING simplString );
        FUNCTION cisco_searchItemType ( STRING simplString );
        FUNCTION cisco_topComplete ( LONG_INTEGER simplValue );
        FUNCTION cisco_selectedItemName ( STRING simplString );
        FUNCTION cisco_selectedItemNumber ( STRING simplString );
        FUNCTION cisco_totalResults ( LONG_INTEGER simplValue );
        FUNCTION cisco_resultsDisplayRange ( STRING simplString );
        FUNCTION searchChars ( STRING paramSearch );
        FUNCTION selectItem ( SIGNED_LONG_INTEGER paramSelectedItem );
        STRING_FUNCTION phoneBookList ( SIGNED_LONG_INTEGER paramEntryNumber );
        FUNCTION upOneLevel ();
        FUNCTION topLevel ();
        FUNCTION clearSearch ();
        FUNCTION dial ( SIGNED_LONG_INTEGER paramSelectedEntry );
        FUNCTION processResponse ( STRING paramResponse );
        FUNCTION setSipEnabled ( LONG_INTEGER paramSipEnabled );
        FUNCTION setH323Enabled ( LONG_INTEGER paramH323Enabled );
        FUNCTION setPhoneBookLocation ( STRING paramLocation );
        FUNCTION DownloadPhoneBook ( ePhoneBookLocation paramPhoneBookLocation );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty delegateCommndToSendChange sendCommandEvent;
        DelegateProperty delegateClearSearchComplete searchClearCompleteEvent;
        DelegateProperty delegateCurrentLevel currentLevelEvent;
        DelegateProperty delegateNumberOfResultsChange numberOfResultsEvent;
        DelegateProperty delegateSearchComplete searchCompleteEvent;
        DelegateProperty delegateSearchPathBarChange searchPathBarEvent;
        DelegateProperty delegateSelectedItemChange selectedItemEvent;
        DelegateProperty delegateUpOneLevelComplete upOneLevelEvent;
        DelegateProperty delgateSearchStringChange searchStringEvent;
        DelegateProperty delegateDialError dialErrorEvent;
        DelegateProperty delegateSearchItemType searchItemTypeEvent;
        DelegateProperty delegateTopComplete topCompleteEvent;
        DelegateProperty delegateSelectedItemName selectedItemNameEvent;
        DelegateProperty delegateSelectedItemNumber selectedItemNumberEvent;
        DelegateProperty delegateTotalResults totalResultsEvent;
        DelegateProperty delegateResultsDisplayRange resultsDisplayRangeEvent;
        eConferenceCallType Type;
    };

    static class eConferenceCallRate // enum
    {
        static SIGNED_LONG_INTEGER Default;
        static SIGNED_LONG_INTEGER Rate64Kbps;
        static SIGNED_LONG_INTEGER Rate128Kbps;
        static SIGNED_LONG_INTEGER Rate256Kbps;
        static SIGNED_LONG_INTEGER Rate384Kbps;
        static SIGNED_LONG_INTEGER Rate512Kbps;
        static SIGNED_LONG_INTEGER Rate768Kbps;
        static SIGNED_LONG_INTEGER Rate1152Kbps;
        static SIGNED_LONG_INTEGER Rate1472Kbps;
        static SIGNED_LONG_INTEGER Rate1920Kbps;
        static SIGNED_LONG_INTEGER Rate2560Kbps;
        static SIGNED_LONG_INTEGER Rate3072Kbps;
        static SIGNED_LONG_INTEGER Rate4000Kbps;
        static SIGNED_LONG_INTEGER Rate6000Kbps;
    };

    static class eConferenceCallProtocol // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER H323;
        static SIGNED_LONG_INTEGER Sip;
        static SIGNED_LONG_INTEGER H320;
    };

    static class eConferenceCallType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Video;
        static SIGNED_LONG_INTEGER Audio;
        static SIGNED_LONG_INTEGER AudioCanEscalate;
        static SIGNED_LONG_INTEGER ForwardAllCall;
    };

    static class ePhoneBookContactType // enum
    {
        static SIGNED_LONG_INTEGER Root;
        static SIGNED_LONG_INTEGER Directory;
        static SIGNED_LONG_INTEGER Contact;
        static SIGNED_LONG_INTEGER Unknown;
    };

    static class ePhoneBookLocation // enum
    {
        static SIGNED_LONG_INTEGER Corporate;
        static SIGNED_LONG_INTEGER Local;
    };

     class Contact 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ePhoneBookContactType Type;
        STRING Name[];
        STRING Id[];
    };

     class MethodOfContact 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Id;
        STRING Number[];
        eConferenceCallProtocol Protocol;
        Contact Contact;
        SIGNED_LONG_INTEGER CallRate;
        eConferenceCallType CallType;
    };

     class Searches 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION clear ();
        FUNCTION clearSet ();
        FUNCTION clearNewSet ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING searchString[];
        STRING displayRangeString[];
        LONG_INTEGER numberOfResults;
        SIGNED_LONG_INTEGER selectedItem;
        LONG_INTEGER currentSet;
        LONG_INTEGER totalSets;
        LONG_INTEGER totalResults;
        LONG_INTEGER firstItem;
        LONG_INTEGER lastItem;

        // class properties
    };

