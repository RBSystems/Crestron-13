namespace Cisco_SX80_Phone_Book;
        // class declarations
         class PhoneBookLocation;
         class PhoneBookContactType;
         class Contact;
         class ConferenceCallStatus;
         class ConferenceCallType;
         class ConferenceCallProtocol;
         class ConferenceCallRate;
         class ConferenceEncryptionMode;
         class ConferenceCallChange;
         class ConferenceCallDirection;
         class PhoneBookHelper;
         class MethodOfContact;
    static class PhoneBookLocation // enum
    {
        static SIGNED_LONG_INTEGER Corporate;
        static SIGNED_LONG_INTEGER Local;
        static SIGNED_LONG_INTEGER Favorites;
        static SIGNED_LONG_INTEGER Recent;
    };

    static class PhoneBookContactType // enum
    {
        static SIGNED_LONG_INTEGER Root;
        static SIGNED_LONG_INTEGER Directory;
        static SIGNED_LONG_INTEGER Contact;
    };

    static class ConferenceCallStatus // enum
    {
        static SIGNED_LONG_INTEGER Idle;
        static SIGNED_LONG_INTEGER Dialling;
        static SIGNED_LONG_INTEGER Ringing;
        static SIGNED_LONG_INTEGER Connecting;
        static SIGNED_LONG_INTEGER Connected;
        static SIGNED_LONG_INTEGER Disconnecting;
        static SIGNED_LONG_INTEGER OnHold;
        static SIGNED_LONG_INTEGER EarlyMedia;
        static SIGNED_LONG_INTEGER Preserved;
        static SIGNED_LONG_INTEGER RemotePreserved;
        static SIGNED_LONG_INTEGER Unknown;
    };

    static class ConferenceCallType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Video;
        static SIGNED_LONG_INTEGER Audio;
        static SIGNED_LONG_INTEGER AudioCanEscalate;
        static SIGNED_LONG_INTEGER ForwardAllCall;
    };

    static class ConferenceCallProtocol // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER H323;
        static SIGNED_LONG_INTEGER Sip;
        static SIGNED_LONG_INTEGER H320;
        static SIGNED_LONG_INTEGER ISDN;
        static SIGNED_LONG_INTEGER IP;
        static SIGNED_LONG_INTEGER Phone;
        static SIGNED_LONG_INTEGER LDAP;
        static SIGNED_LONG_INTEGER LYNC;
        static SIGNED_LONG_INTEGER GDS;
    };

    static class ConferenceCallRate // enum
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

    static class ConferenceEncryptionMode // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER On;
        static SIGNED_LONG_INTEGER RequiredVideo;
        static SIGNED_LONG_INTEGER RequiredAll;
        static SIGNED_LONG_INTEGER BestEffort;
    };

    static class ConferenceCallChange // enum
    {
        static SIGNED_LONG_INTEGER Status;
        static SIGNED_LONG_INTEGER Type;
        static SIGNED_LONG_INTEGER RemoteNumber;
        static SIGNED_LONG_INTEGER CallbackNumber;
        static SIGNED_LONG_INTEGER RemoteSite;
        static SIGNED_LONG_INTEGER Duration;
        static SIGNED_LONG_INTEGER TransmitRate;
        static SIGNED_LONG_INTEGER Direction;
        static SIGNED_LONG_INTEGER Id;
        static SIGNED_LONG_INTEGER ReceiveRate;
        static SIGNED_LONG_INTEGER SupportPresentation;
        static SIGNED_LONG_INTEGER NewCall;
    };

    static class ConferenceCallDirection // enum
    {
        static SIGNED_LONG_INTEGER Incoming;
        static SIGNED_LONG_INTEGER Outgoing;
        static SIGNED_LONG_INTEGER Unknown;
    };

     class PhoneBookHelper 
    {
        // class delegates
        delegate FUNCTION delegateCommandToSendChange ( SIMPLSHARPSTRING toSimplPlus );
        delegate FUNCTION delegateDownloadComplete ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateDownloadBusy ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateSearchComplete ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateSearchBusy ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateCurrentLevelEvent ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateSelectEntryEvent ( LONG_INTEGER toSimplPlus );
        delegate FUNCTION delegateSearchCurrentLevelEvent ( LONG_INTEGER toSimplPlus );

        // class events

        // class functions
        FUNCTION cisco_sendCommand ( SIMPLSHARPSTRING simplString );
        FUNCTION cisco_downloadComplete ( LONG_INTEGER simplValue );
        FUNCTION cisco_downloadBusy ( LONG_INTEGER simplValue );
        FUNCTION cisco_searchComplete ( LONG_INTEGER simplValue );
        FUNCTION cisco_searchBusy ( LONG_INTEGER simplValue );
        FUNCTION cisco_currentLevel ( LONG_INTEGER simplValue );
        FUNCTION cisco_selectEntry ( LONG_INTEGER simplValue );
        FUNCTION cisco_searchCurrentLevel ( LONG_INTEGER simplValue );
        FUNCTION cisco_searchSelectEntry ( LONG_INTEGER simplValue );
        FUNCTION startDownloadPhoneBook ( STRING paramPhoneBookLocation );
        FUNCTION PhoneBookDownloadStarted ();
        FUNCTION AbortPhonebookDownload ();
        FUNCTION ResendPhoneBookRequest ();
        FUNCTION CancelDownload ();
        FUNCTION PhoneBookEnd ();
        FUNCTION UpdateContactName ( STRING id , STRING name );
        FUNCTION UpdateContactId ( STRING id , STRING value );
        FUNCTION UpdateMethodOfContactId ( STRING id , SIGNED_LONG_INTEGER methodId );
        FUNCTION UpdateMethodOfContactNumber ( STRING id , STRING number );
        FUNCTION UpdateMethodOfContactProtocol ( STRING id , STRING protocol );
        FUNCTION UpdateMethodOfContactCallRate ( STRING id , SIGNED_LONG_INTEGER callrate );
        FUNCTION UpdateMethodOfContactCallType ( STRING id , STRING calltype );
        FUNCTION UpdateFolderName ( STRING id , STRING name );
        FUNCTION UpdateFolderId ( STRING id , STRING folderId );
        FUNCTION DataReceivedEventArgs ( STRING data );
        FUNCTION startSearch ( STRING s );
        STRING_FUNCTION searchResultsList ( SIGNED_LONG_INTEGER paramResultNumber );
        LONG_INTEGER_FUNCTION searchResultsCount ();
        STRING_FUNCTION phoneBookList ( SIGNED_LONG_INTEGER paramEntryNumber );
        STRING_FUNCTION getSelectedEntryName ();
        STRING_FUNCTION getSelectedResultName ();
        STRING_FUNCTION getSelectedEntryType ();
        STRING_FUNCTION getSelectedEntryParentFolderName ();
        STRING_FUNCTION getSelectedResultType ();
        SIGNED_LONG_INTEGER_FUNCTION phoneBookCount ( SIGNED_LONG_INTEGER paramCurrentLevel );
        FUNCTION selectPhoneBookEntry ( SIGNED_LONG_INTEGER paramSelectedEntry );
        FUNCTION selectSearchEntry ( SIGNED_LONG_INTEGER paramSelectedEntry );
        FUNCTION clearSearch ();
        STRING_FUNCTION getPhoneBookEntryType ( SIGNED_LONG_INTEGER paramCurrentEntry );
        STRING_FUNCTION getPhoneBookEntryNumber ();
        STRING_FUNCTION getSearchEntryType ( SIGNED_LONG_INTEGER paramCurrentEntry );
        STRING_FUNCTION getSearchEntryNumber ();
        FUNCTION phoneBookTop ();
        FUNCTION phoneBookUpOneLevel ();
        FUNCTION searchTop ();
        FUNCTION searchUpOneLevel ();
        FUNCTION clearSelected ();
        FUNCTION clearSearchSelected ();
        STRING_FUNCTION dialPhoneBookEntry ( SIGNED_LONG_INTEGER paramEntryNumber );
        STRING_FUNCTION dialSearchEntry ( SIGNED_LONG_INTEGER paramEntryNumber );
        STRING_FUNCTION TransferCall ( SIGNED_LONG_INTEGER paramEntryNumber , SIGNED_LONG_INTEGER paramCallId );
        STRING_FUNCTION searchTransfer ( SIGNED_LONG_INTEGER paramEntryNumber , SIGNED_LONG_INTEGER paramCallId );
        FUNCTION setSipEnabled ( SIGNED_LONG_INTEGER paramEnabled );
        FUNCTION setH323Enabled ( SIGNED_LONG_INTEGER paramEnabled );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER CurrentPhoneBookOffset;
        SIGNED_LONG_INTEGER RowsExpected;
        DelegateProperty delegateCommandToSendChange sendCommandEvent;
        DelegateProperty delegateDownloadComplete downloadCompleteEvent;
        DelegateProperty delegateDownloadBusy downloadBusyEvent;
        DelegateProperty delegateSearchComplete searchCompleteEvent;
        DelegateProperty delegateSearchBusy searchBusyEvent;
        DelegateProperty delegateCurrentLevelEvent currentLevelEvent;
        DelegateProperty delegateSelectEntryEvent selectEntryEvent;
        DelegateProperty delegateSearchCurrentLevelEvent searchCurrentLevelEvent;
        DelegateProperty delegateSelectEntryEvent searchSelectEntryEvent;
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
        ConferenceCallProtocol Protocol;
        SIGNED_LONG_INTEGER CallRate;
        ConferenceCallType CallType;
        STRING Number[];
    };

