using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Usage.Record 
{

    /// <summary>
    /// TodayResource
    /// </summary>
    public class TodayResource : Resource 
    {
        public sealed class CategoryEnum : StringEnum 
        {
            private CategoryEnum(string value) : base(value) {}
            public CategoryEnum() {}

            public static readonly CategoryEnum AnsweringMachineDetection = new CategoryEnum("answering-machine-detection");
            public static readonly CategoryEnum AuthyAuthentications = new CategoryEnum("authy-authentications");
            public static readonly CategoryEnum AuthyCallsOutbound = new CategoryEnum("authy-calls-outbound");
            public static readonly CategoryEnum AuthyMonthlyFees = new CategoryEnum("authy-monthly-fees");
            public static readonly CategoryEnum AuthyPhoneIntelligence = new CategoryEnum("authy-phone-intelligence");
            public static readonly CategoryEnum AuthyPhoneVerifications = new CategoryEnum("authy-phone-verifications");
            public static readonly CategoryEnum AuthySmsOutbound = new CategoryEnum("authy-sms-outbound");
            public static readonly CategoryEnum CallProgessEvents = new CategoryEnum("call-progess-events");
            public static readonly CategoryEnum Calleridlookups = new CategoryEnum("calleridlookups");
            public static readonly CategoryEnum Calls = new CategoryEnum("calls");
            public static readonly CategoryEnum CallsClient = new CategoryEnum("calls-client");
            public static readonly CategoryEnum CallsGlobalconference = new CategoryEnum("calls-globalconference");
            public static readonly CategoryEnum CallsInbound = new CategoryEnum("calls-inbound");
            public static readonly CategoryEnum CallsInboundLocal = new CategoryEnum("calls-inbound-local");
            public static readonly CategoryEnum CallsInboundMobile = new CategoryEnum("calls-inbound-mobile");
            public static readonly CategoryEnum CallsInboundTollfree = new CategoryEnum("calls-inbound-tollfree");
            public static readonly CategoryEnum CallsOutbound = new CategoryEnum("calls-outbound");
            public static readonly CategoryEnum CallsRecordings = new CategoryEnum("calls-recordings");
            public static readonly CategoryEnum CallsSip = new CategoryEnum("calls-sip");
            public static readonly CategoryEnum CallsSipInbound = new CategoryEnum("calls-sip-inbound");
            public static readonly CategoryEnum CallsSipOutbound = new CategoryEnum("calls-sip-outbound");
            public static readonly CategoryEnum CarrierLookups = new CategoryEnum("carrier-lookups");
            public static readonly CategoryEnum Conversations = new CategoryEnum("conversations");
            public static readonly CategoryEnum ConversationsApiRequests = new CategoryEnum("conversations-api-requests");
            public static readonly CategoryEnum ConversationsConversationEvents = new CategoryEnum("conversations-conversation-events");
            public static readonly CategoryEnum ConversationsEndpointConnectivity = new CategoryEnum("conversations-endpoint-connectivity");
            public static readonly CategoryEnum ConversationsEvents = new CategoryEnum("conversations-events");
            public static readonly CategoryEnum ConversationsParticipantEvents = new CategoryEnum("conversations-participant-events");
            public static readonly CategoryEnum ConversationsParticipants = new CategoryEnum("conversations-participants");
            public static readonly CategoryEnum Cps = new CategoryEnum("cps");
            public static readonly CategoryEnum IpMessaging = new CategoryEnum("ip-messaging");
            public static readonly CategoryEnum IpMessagingCommands = new CategoryEnum("ip-messaging-commands");
            public static readonly CategoryEnum IpMessagingDataStorage = new CategoryEnum("ip-messaging-data-storage");
            public static readonly CategoryEnum IpMessagingDataTransfer = new CategoryEnum("ip-messaging-data-transfer");
            public static readonly CategoryEnum IpMessagingEndpointConnectivity = new CategoryEnum("ip-messaging-endpoint-connectivity");
            public static readonly CategoryEnum Lookups = new CategoryEnum("lookups");
            public static readonly CategoryEnum Marketplace = new CategoryEnum("marketplace");
            public static readonly CategoryEnum MarketplaceAlgorithmiaNamedEntityRecognition = new CategoryEnum("marketplace-algorithmia-named-entity-recognition");
            public static readonly CategoryEnum MarketplaceDigitalSegmentBusinessInfo = new CategoryEnum("marketplace-digital-segment-business-info");
            public static readonly CategoryEnum MarketplaceGoogleSpeechToText = new CategoryEnum("marketplace-google-speech-to-text");
            public static readonly CategoryEnum MarketplaceIbmWatsonMessageInsights = new CategoryEnum("marketplace-ibm-watson-message-insights");
            public static readonly CategoryEnum MarketplaceIbmWatsonMessageSentiment = new CategoryEnum("marketplace-ibm-watson-message-sentiment");
            public static readonly CategoryEnum MarketplaceIbmWatsonRecordingAnalysis = new CategoryEnum("marketplace-ibm-watson-recording-analysis");
            public static readonly CategoryEnum MarketplaceIcehookSystemsScout = new CategoryEnum("marketplace-icehook-systems-scout");
            public static readonly CategoryEnum MarketplaceInfogroupDataaxleBizinfo = new CategoryEnum("marketplace-infogroup-dataaxle-bizinfo");
            public static readonly CategoryEnum MarketplaceMarchexCleancall = new CategoryEnum("marketplace-marchex-cleancall");
            public static readonly CategoryEnum MarketplaceMarchexSentimentAnalysisForSms = new CategoryEnum("marketplace-marchex-sentiment-analysis-for-sms");
            public static readonly CategoryEnum MarketplaceMarketplaceNextcallerSocialId = new CategoryEnum("marketplace-marketplace-nextcaller-social-id");
            public static readonly CategoryEnum MarketplaceMobileCommonsOptOutClassifier = new CategoryEnum("marketplace-mobile-commons-opt-out-classifier");
            public static readonly CategoryEnum MarketplaceNexiwaveVoicemailToText = new CategoryEnum("marketplace-nexiwave-voicemail-to-text");
            public static readonly CategoryEnum MarketplaceNextcallerAdvancedCallerIdentification = new CategoryEnum("marketplace-nextcaller-advanced-caller-identification");
            public static readonly CategoryEnum MarketplaceNomoroboSpamScore = new CategoryEnum("marketplace-nomorobo-spam-score");
            public static readonly CategoryEnum MarketplacePayfoneTcpaCompliance = new CategoryEnum("marketplace-payfone-tcpa-compliance");
            public static readonly CategoryEnum MarketplaceTeloOpencnam = new CategoryEnum("marketplace-telo-opencnam");
            public static readonly CategoryEnum MarketplaceTruecnamTrueSpam = new CategoryEnum("marketplace-truecnam-true-spam");
            public static readonly CategoryEnum MarketplaceTwilioCallerNameLookupUs = new CategoryEnum("marketplace-twilio-caller-name-lookup-us");
            public static readonly CategoryEnum MarketplaceTwilioCarrierInformationLookup = new CategoryEnum("marketplace-twilio-carrier-information-lookup");
            public static readonly CategoryEnum MarketplaceVoicebasePci = new CategoryEnum("marketplace-voicebase-pci");
            public static readonly CategoryEnum MarketplaceVoicebaseTranscription = new CategoryEnum("marketplace-voicebase-transcription");
            public static readonly CategoryEnum MarketplaceWhitepagesProCallerIdentification = new CategoryEnum("marketplace-whitepages-pro-caller-identification");
            public static readonly CategoryEnum MarketplaceWhitepagesProPhoneIntelligence = new CategoryEnum("marketplace-whitepages-pro-phone-intelligence");
            public static readonly CategoryEnum MarketplaceWhitepagesProPhoneReputation = new CategoryEnum("marketplace-whitepages-pro-phone-reputation");
            public static readonly CategoryEnum MarketplaceWolframShortAnswer = new CategoryEnum("marketplace-wolfram-short-answer");
            public static readonly CategoryEnum MarketplaceWolfarmSpokenResults = new CategoryEnum("marketplace-wolfarm-spoken-results");
            public static readonly CategoryEnum MarketplaceDeepgramPhraseDetector = new CategoryEnum("marketplace-deepgram-phrase-detector");
            public static readonly CategoryEnum MarketplaceConvrizaAbaba = new CategoryEnum("marketplace-convriza-ababa");
            public static readonly CategoryEnum MarketplaceIbmWatsonToneAnalyzer = new CategoryEnum("marketplace-ibm-watson-tone-analyzer");
            public static readonly CategoryEnum MarketplaceRemeetingAutomaticSpeechRecognition = new CategoryEnum("marketplace-remeeting-automatic-speech-recognition");
            public static readonly CategoryEnum MarketplaceTcpaDefenseSolutionsBlacklistFeed = new CategoryEnum("marketplace-tcpa-defense-solutions-blacklist-feed");
            public static readonly CategoryEnum Mediastorage = new CategoryEnum("mediastorage");
            public static readonly CategoryEnum Mms = new CategoryEnum("mms");
            public static readonly CategoryEnum MmsInbound = new CategoryEnum("mms-inbound");
            public static readonly CategoryEnum MmsInboundLongcode = new CategoryEnum("mms-inbound-longcode");
            public static readonly CategoryEnum MmsInboundShortcode = new CategoryEnum("mms-inbound-shortcode");
            public static readonly CategoryEnum MmsOutbound = new CategoryEnum("mms-outbound");
            public static readonly CategoryEnum MmsOutboundLongcode = new CategoryEnum("mms-outbound-longcode");
            public static readonly CategoryEnum MmsOutboundShortcode = new CategoryEnum("mms-outbound-shortcode");
            public static readonly CategoryEnum MonitorReads = new CategoryEnum("monitor-reads");
            public static readonly CategoryEnum MonitorStorage = new CategoryEnum("monitor-storage");
            public static readonly CategoryEnum MonitorWrites = new CategoryEnum("monitor-writes");
            public static readonly CategoryEnum Notify = new CategoryEnum("notify");
            public static readonly CategoryEnum NotifyActionsAttempts = new CategoryEnum("notify-actions-attempts");
            public static readonly CategoryEnum NotifyChannels = new CategoryEnum("notify-channels");
            public static readonly CategoryEnum NumberFormatLookups = new CategoryEnum("number-format-lookups");
            public static readonly CategoryEnum Pchat = new CategoryEnum("pchat");
            public static readonly CategoryEnum PchatActions = new CategoryEnum("pchat-actions");
            public static readonly CategoryEnum PchatAps = new CategoryEnum("pchat-aps");
            public static readonly CategoryEnum PchatNotifications = new CategoryEnum("pchat-notifications");
            public static readonly CategoryEnum PchatReads = new CategoryEnum("pchat-reads");
            public static readonly CategoryEnum PchatUsers = new CategoryEnum("pchat-users");
            public static readonly CategoryEnum PchatMessages = new CategoryEnum("pchat-messages");
            public static readonly CategoryEnum Pfax = new CategoryEnum("pfax");
            public static readonly CategoryEnum PfaxMinutes = new CategoryEnum("pfax-minutes");
            public static readonly CategoryEnum PfaxMinutesInbound = new CategoryEnum("pfax-minutes-inbound");
            public static readonly CategoryEnum PfaxMinutesOutbound = new CategoryEnum("pfax-minutes-outbound");
            public static readonly CategoryEnum PfaxPages = new CategoryEnum("pfax-pages");
            public static readonly CategoryEnum Phonenumbers = new CategoryEnum("phonenumbers");
            public static readonly CategoryEnum PhonenumbersCps = new CategoryEnum("phonenumbers-cps");
            public static readonly CategoryEnum PhonenumbersEmergency = new CategoryEnum("phonenumbers-emergency");
            public static readonly CategoryEnum PhonenumbersLocal = new CategoryEnum("phonenumbers-local");
            public static readonly CategoryEnum PhonenumbersMobile = new CategoryEnum("phonenumbers-mobile");
            public static readonly CategoryEnum PhonenumbersSetups = new CategoryEnum("phonenumbers-setups");
            public static readonly CategoryEnum PhonenumbersTollfree = new CategoryEnum("phonenumbers-tollfree");
            public static readonly CategoryEnum Premiumsupport = new CategoryEnum("premiumsupport");
            public static readonly CategoryEnum Pv = new CategoryEnum("pv");
            public static readonly CategoryEnum PvRoomParticipants = new CategoryEnum("pv-room-participants");
            public static readonly CategoryEnum PvRoomParticipantsAu1 = new CategoryEnum("pv-room-participants-au1");
            public static readonly CategoryEnum PvRoomParticipantsBr1 = new CategoryEnum("pv-room-participants-br1");
            public static readonly CategoryEnum PvRoomParticipantsIe1 = new CategoryEnum("pv-room-participants-ie1");
            public static readonly CategoryEnum PvRoomParticipantsJp1 = new CategoryEnum("pv-room-participants-jp1");
            public static readonly CategoryEnum PvRoomParticipantsSg1 = new CategoryEnum("pv-room-participants-sg1");
            public static readonly CategoryEnum PvRoomParticipantsUs1 = new CategoryEnum("pv-room-participants-us1");
            public static readonly CategoryEnum PvRoomParticipantsUs2 = new CategoryEnum("pv-room-participants-us2");
            public static readonly CategoryEnum PvRooms = new CategoryEnum("pv-rooms");
            public static readonly CategoryEnum PvSipEndpointRegistrations = new CategoryEnum("pv-sip-endpoint-registrations");
            public static readonly CategoryEnum Recordings = new CategoryEnum("recordings");
            public static readonly CategoryEnum Recordingstorage = new CategoryEnum("recordingstorage");
            public static readonly CategoryEnum Shortcodes = new CategoryEnum("shortcodes");
            public static readonly CategoryEnum ShortcodesCustomerowned = new CategoryEnum("shortcodes-customerowned");
            public static readonly CategoryEnum ShortcodesMmsEnablement = new CategoryEnum("shortcodes-mms-enablement");
            public static readonly CategoryEnum ShortcodesMps = new CategoryEnum("shortcodes-mps");
            public static readonly CategoryEnum ShortcodesRandom = new CategoryEnum("shortcodes-random");
            public static readonly CategoryEnum ShortcodesUk = new CategoryEnum("shortcodes-uk");
            public static readonly CategoryEnum ShortcodesVanity = new CategoryEnum("shortcodes-vanity");
            public static readonly CategoryEnum Sms = new CategoryEnum("sms");
            public static readonly CategoryEnum SmsInbound = new CategoryEnum("sms-inbound");
            public static readonly CategoryEnum SmsInboundLongcode = new CategoryEnum("sms-inbound-longcode");
            public static readonly CategoryEnum SmsInboundShortcode = new CategoryEnum("sms-inbound-shortcode");
            public static readonly CategoryEnum SmsOutbound = new CategoryEnum("sms-outbound");
            public static readonly CategoryEnum SmsOutboundContentInspection = new CategoryEnum("sms-outbound-content-inspection");
            public static readonly CategoryEnum SmsOutboundLongcode = new CategoryEnum("sms-outbound-longcode");
            public static readonly CategoryEnum SmsOutboundShortcode = new CategoryEnum("sms-outbound-shortcode");
            public static readonly CategoryEnum SmsMessagesFeatures = new CategoryEnum("sms-messages-features");
            public static readonly CategoryEnum TaskrouterTasks = new CategoryEnum("taskrouter-tasks");
            public static readonly CategoryEnum Totalprice = new CategoryEnum("totalprice");
            public static readonly CategoryEnum Transcriptions = new CategoryEnum("transcriptions");
            public static readonly CategoryEnum TrunkingCps = new CategoryEnum("trunking-cps");
            public static readonly CategoryEnum TrunkingEmergencyCalls = new CategoryEnum("trunking-emergency-calls");
            public static readonly CategoryEnum TrunkingOrigination = new CategoryEnum("trunking-origination");
            public static readonly CategoryEnum TrunkingOriginationLocal = new CategoryEnum("trunking-origination-local");
            public static readonly CategoryEnum TrunkingOriginationMobile = new CategoryEnum("trunking-origination-mobile");
            public static readonly CategoryEnum TrunkingOriginationTollfree = new CategoryEnum("trunking-origination-tollfree");
            public static readonly CategoryEnum TrunkingRecordings = new CategoryEnum("trunking-recordings");
            public static readonly CategoryEnum TrunkingSecure = new CategoryEnum("trunking-secure");
            public static readonly CategoryEnum TrunkingTermination = new CategoryEnum("trunking-termination");
            public static readonly CategoryEnum Turnmegabytes = new CategoryEnum("turnmegabytes");
            public static readonly CategoryEnum TurnmegabytesAustralia = new CategoryEnum("turnmegabytes-australia");
            public static readonly CategoryEnum TurnmegabytesBrasil = new CategoryEnum("turnmegabytes-brasil");
            public static readonly CategoryEnum TurnmegabytesIreland = new CategoryEnum("turnmegabytes-ireland");
            public static readonly CategoryEnum TurnmegabytesJapan = new CategoryEnum("turnmegabytes-japan");
            public static readonly CategoryEnum TurnmegabytesSingapore = new CategoryEnum("turnmegabytes-singapore");
            public static readonly CategoryEnum TurnmegabytesUseast = new CategoryEnum("turnmegabytes-useast");
            public static readonly CategoryEnum TurnmegabytesUswest = new CategoryEnum("turnmegabytes-uswest");
            public static readonly CategoryEnum TwilioInterconnect = new CategoryEnum("twilio-interconnect");
            public static readonly CategoryEnum VoiceInsights = new CategoryEnum("voice-insights");
            public static readonly CategoryEnum Wireless = new CategoryEnum("wireless");
            public static readonly CategoryEnum WirelessOrders = new CategoryEnum("wireless-orders");
            public static readonly CategoryEnum WirelessOrdersBulk = new CategoryEnum("wireless-orders-bulk");
            public static readonly CategoryEnum WirelessOrdersEsim = new CategoryEnum("wireless-orders-esim");
            public static readonly CategoryEnum WirelessOrdersStarter = new CategoryEnum("wireless-orders-starter");
            public static readonly CategoryEnum WirelessUsage = new CategoryEnum("wireless-usage");
            public static readonly CategoryEnum WirelessUsageCommands = new CategoryEnum("wireless-usage-commands");
            public static readonly CategoryEnum WirelessUsageCommandsHome = new CategoryEnum("wireless-usage-commands-home");
            public static readonly CategoryEnum WirelessUsageCommandsRoaming = new CategoryEnum("wireless-usage-commands-roaming");
            public static readonly CategoryEnum WirelessUsageData = new CategoryEnum("wireless-usage-data");
            public static readonly CategoryEnum WirelessUsageDataCustomAdditionalmb = new CategoryEnum("wireless-usage-data-custom-additionalmb");
            public static readonly CategoryEnum WirelessUsageDataCustomFirst5Mb = new CategoryEnum("wireless-usage-data-custom-first5mb");
            public static readonly CategoryEnum WirelessUsageDataDomesticRoaming = new CategoryEnum("wireless-usage-data-domestic-roaming");
            public static readonly CategoryEnum WirelessUsageDataIndividualAdditionalgb = new CategoryEnum("wireless-usage-data-individual-additionalgb");
            public static readonly CategoryEnum WirelessUsageDataIndividualFirstgb = new CategoryEnum("wireless-usage-data-individual-firstgb");
            public static readonly CategoryEnum WirelessUsageDataInternationalRoamingCanada = new CategoryEnum("wireless-usage-data-international-roaming-canada");
            public static readonly CategoryEnum WirelessUsageDataInternationalRoamingIndia = new CategoryEnum("wireless-usage-data-international-roaming-india");
            public static readonly CategoryEnum WirelessUsageDataInternationalRoamingMexico = new CategoryEnum("wireless-usage-data-international-roaming-mexico");
            public static readonly CategoryEnum WirelessUsageDataPooled = new CategoryEnum("wireless-usage-data-pooled");
            public static readonly CategoryEnum WirelessUsageDataPooledDownlink = new CategoryEnum("wireless-usage-data-pooled-downlink");
            public static readonly CategoryEnum WirelessUsageDataPooledUplink = new CategoryEnum("wireless-usage-data-pooled-uplink");
            public static readonly CategoryEnum WirelessUsageMrc = new CategoryEnum("wireless-usage-mrc");
            public static readonly CategoryEnum WirelessUsageMrcCustom = new CategoryEnum("wireless-usage-mrc-custom");
            public static readonly CategoryEnum WirelessUsageMrcIndividual = new CategoryEnum("wireless-usage-mrc-individual");
            public static readonly CategoryEnum WirelessUsageMrcPooled = new CategoryEnum("wireless-usage-mrc-pooled");
            public static readonly CategoryEnum Sync = new CategoryEnum("sync");
        }

        private static Request BuildReadRequest(ReadTodayOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Usage/Records/Today.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Today parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Today </returns> 
        public static ResourceSet<TodayResource> Read(ReadTodayOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<TodayResource>.FromJson("usage_records", response.Content);
            return new ResourceSet<TodayResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Today parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Today </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TodayResource>> ReadAsync(ReadTodayOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TodayResource>.FromJson("usage_records", response.Content);
            return new ResourceSet<TodayResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="category"> The category </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Today </returns> 
        public static ResourceSet<TodayResource> Read(string pathAccountSid = null, TodayResource.CategoryEnum category = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTodayOptions{PathAccountSid = pathAccountSid, Category = category, StartDate = startDate, EndDate = endDate, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="category"> The category </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Today </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TodayResource>> ReadAsync(string pathAccountSid = null, TodayResource.CategoryEnum category = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTodayOptions{PathAccountSid = pathAccountSid, Category = category, StartDate = startDate, EndDate = endDate, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<TodayResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TodayResource>.FromJson("usage_records", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<TodayResource> NextPage(Page<TodayResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<TodayResource>.FromJson("usage_records", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<TodayResource> PreviousPage(Page<TodayResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<TodayResource>.FromJson("usage_records", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a TodayResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TodayResource object represented by the provided JSON </returns> 
        public static TodayResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TodayResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The api_version
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The category
        /// </summary>
        [JsonProperty("category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TodayResource.CategoryEnum Category { get; private set; }
        /// <summary>
        /// The count
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; private set; }
        /// <summary>
        /// The count_unit
        /// </summary>
        [JsonProperty("count_unit")]
        public string CountUnit { get; private set; }
        /// <summary>
        /// The description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// The end_date
        /// </summary>
        [JsonProperty("end_date")]
        public DateTime? EndDate { get; private set; }
        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; private set; }
        /// <summary>
        /// The price_unit
        /// </summary>
        [JsonProperty("price_unit")]
        public string PriceUnit { get; private set; }
        /// <summary>
        /// The start_date
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime? StartDate { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The usage
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; private set; }
        /// <summary>
        /// The usage_unit
        /// </summary>
        [JsonProperty("usage_unit")]
        public string UsageUnit { get; private set; }

        private TodayResource()
        {

        }
    }

}