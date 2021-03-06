using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Chat.V2 
{

    /// <summary>
    /// ServiceResource
    /// </summary>
    public class ServiceResource : Resource 
    {
        private static Request BuildFetchRequest(FetchServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Fetch(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static bool Delete(DeleteServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                "/v2/Services",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Create(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Create(string friendlyName, ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(friendlyName);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(string friendlyName, ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(friendlyName);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                "/v2/Services",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ResourceSet<ServiceResource> Read(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ResourceSet<ServiceResource> Read(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions{PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions{PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ServiceResource> NextPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Chat,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Update(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="defaultServiceRoleSid"> The default_service_role_sid </param>
        /// <param name="defaultChannelRoleSid"> The default_channel_role_sid </param>
        /// <param name="defaultChannelCreatorRoleSid"> The default_channel_creator_role_sid </param>
        /// <param name="readStatusEnabled"> The read_status_enabled </param>
        /// <param name="reachabilityEnabled"> The reachability_enabled </param>
        /// <param name="typingIndicatorTimeout"> The typing_indicator_timeout </param>
        /// <param name="consumptionReportInterval"> The consumption_report_interval </param>
        /// <param name="notificationsNewMessageEnabled"> The notifications.new_message.enabled </param>
        /// <param name="notificationsNewMessageTemplate"> The notifications.new_message.template </param>
        /// <param name="notificationsNewMessageSound"> The notifications.new_message.sound </param>
        /// <param name="notificationsNewMessageBadgeCountEnabled"> The notifications.new_message.badge_count_enabled </param>
        /// <param name="notificationsAddedToChannelEnabled"> The notifications.added_to_channel.enabled </param>
        /// <param name="notificationsAddedToChannelTemplate"> The notifications.added_to_channel.template </param>
        /// <param name="notificationsAddedToChannelSound"> The notifications.added_to_channel.sound </param>
        /// <param name="notificationsRemovedFromChannelEnabled"> The notifications.removed_from_channel.enabled </param>
        /// <param name="notificationsRemovedFromChannelTemplate"> The notifications.removed_from_channel.template </param>
        /// <param name="notificationsRemovedFromChannelSound"> The notifications.removed_from_channel.sound </param>
        /// <param name="notificationsInvitedToChannelEnabled"> The notifications.invited_to_channel.enabled </param>
        /// <param name="notificationsInvitedToChannelTemplate"> The notifications.invited_to_channel.template </param>
        /// <param name="notificationsInvitedToChannelSound"> The notifications.invited_to_channel.sound </param>
        /// <param name="preWebhookUrl"> The pre_webhook_url </param>
        /// <param name="postWebhookUrl"> The post_webhook_url </param>
        /// <param name="webhookMethod"> The webhook_method </param>
        /// <param name="webhookFilters"> The webhook_filters </param>
        /// <param name="limitsChannelMembers"> The limits.channel_members </param>
        /// <param name="limitsUserChannels"> The limits.user_channels </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Update(string pathSid, string friendlyName = null, string defaultServiceRoleSid = null, string defaultChannelRoleSid = null, string defaultChannelCreatorRoleSid = null, bool? readStatusEnabled = null, bool? reachabilityEnabled = null, int? typingIndicatorTimeout = null, int? consumptionReportInterval = null, bool? notificationsNewMessageEnabled = null, string notificationsNewMessageTemplate = null, string notificationsNewMessageSound = null, bool? notificationsNewMessageBadgeCountEnabled = null, bool? notificationsAddedToChannelEnabled = null, string notificationsAddedToChannelTemplate = null, string notificationsAddedToChannelSound = null, bool? notificationsRemovedFromChannelEnabled = null, string notificationsRemovedFromChannelTemplate = null, string notificationsRemovedFromChannelSound = null, bool? notificationsInvitedToChannelEnabled = null, string notificationsInvitedToChannelTemplate = null, string notificationsInvitedToChannelSound = null, Uri preWebhookUrl = null, Uri postWebhookUrl = null, Twilio.Http.HttpMethod webhookMethod = null, List<string> webhookFilters = null, int? limitsChannelMembers = null, int? limitsUserChannels = null, ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){FriendlyName = friendlyName, DefaultServiceRoleSid = defaultServiceRoleSid, DefaultChannelRoleSid = defaultChannelRoleSid, DefaultChannelCreatorRoleSid = defaultChannelCreatorRoleSid, ReadStatusEnabled = readStatusEnabled, ReachabilityEnabled = reachabilityEnabled, TypingIndicatorTimeout = typingIndicatorTimeout, ConsumptionReportInterval = consumptionReportInterval, NotificationsNewMessageEnabled = notificationsNewMessageEnabled, NotificationsNewMessageTemplate = notificationsNewMessageTemplate, NotificationsNewMessageSound = notificationsNewMessageSound, NotificationsNewMessageBadgeCountEnabled = notificationsNewMessageBadgeCountEnabled, NotificationsAddedToChannelEnabled = notificationsAddedToChannelEnabled, NotificationsAddedToChannelTemplate = notificationsAddedToChannelTemplate, NotificationsAddedToChannelSound = notificationsAddedToChannelSound, NotificationsRemovedFromChannelEnabled = notificationsRemovedFromChannelEnabled, NotificationsRemovedFromChannelTemplate = notificationsRemovedFromChannelTemplate, NotificationsRemovedFromChannelSound = notificationsRemovedFromChannelSound, NotificationsInvitedToChannelEnabled = notificationsInvitedToChannelEnabled, NotificationsInvitedToChannelTemplate = notificationsInvitedToChannelTemplate, NotificationsInvitedToChannelSound = notificationsInvitedToChannelSound, PreWebhookUrl = preWebhookUrl, PostWebhookUrl = postWebhookUrl, WebhookMethod = webhookMethod, WebhookFilters = webhookFilters, LimitsChannelMembers = limitsChannelMembers, LimitsUserChannels = limitsUserChannels};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="defaultServiceRoleSid"> The default_service_role_sid </param>
        /// <param name="defaultChannelRoleSid"> The default_channel_role_sid </param>
        /// <param name="defaultChannelCreatorRoleSid"> The default_channel_creator_role_sid </param>
        /// <param name="readStatusEnabled"> The read_status_enabled </param>
        /// <param name="reachabilityEnabled"> The reachability_enabled </param>
        /// <param name="typingIndicatorTimeout"> The typing_indicator_timeout </param>
        /// <param name="consumptionReportInterval"> The consumption_report_interval </param>
        /// <param name="notificationsNewMessageEnabled"> The notifications.new_message.enabled </param>
        /// <param name="notificationsNewMessageTemplate"> The notifications.new_message.template </param>
        /// <param name="notificationsNewMessageSound"> The notifications.new_message.sound </param>
        /// <param name="notificationsNewMessageBadgeCountEnabled"> The notifications.new_message.badge_count_enabled </param>
        /// <param name="notificationsAddedToChannelEnabled"> The notifications.added_to_channel.enabled </param>
        /// <param name="notificationsAddedToChannelTemplate"> The notifications.added_to_channel.template </param>
        /// <param name="notificationsAddedToChannelSound"> The notifications.added_to_channel.sound </param>
        /// <param name="notificationsRemovedFromChannelEnabled"> The notifications.removed_from_channel.enabled </param>
        /// <param name="notificationsRemovedFromChannelTemplate"> The notifications.removed_from_channel.template </param>
        /// <param name="notificationsRemovedFromChannelSound"> The notifications.removed_from_channel.sound </param>
        /// <param name="notificationsInvitedToChannelEnabled"> The notifications.invited_to_channel.enabled </param>
        /// <param name="notificationsInvitedToChannelTemplate"> The notifications.invited_to_channel.template </param>
        /// <param name="notificationsInvitedToChannelSound"> The notifications.invited_to_channel.sound </param>
        /// <param name="preWebhookUrl"> The pre_webhook_url </param>
        /// <param name="postWebhookUrl"> The post_webhook_url </param>
        /// <param name="webhookMethod"> The webhook_method </param>
        /// <param name="webhookFilters"> The webhook_filters </param>
        /// <param name="limitsChannelMembers"> The limits.channel_members </param>
        /// <param name="limitsUserChannels"> The limits.user_channels </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(string pathSid, string friendlyName = null, string defaultServiceRoleSid = null, string defaultChannelRoleSid = null, string defaultChannelCreatorRoleSid = null, bool? readStatusEnabled = null, bool? reachabilityEnabled = null, int? typingIndicatorTimeout = null, int? consumptionReportInterval = null, bool? notificationsNewMessageEnabled = null, string notificationsNewMessageTemplate = null, string notificationsNewMessageSound = null, bool? notificationsNewMessageBadgeCountEnabled = null, bool? notificationsAddedToChannelEnabled = null, string notificationsAddedToChannelTemplate = null, string notificationsAddedToChannelSound = null, bool? notificationsRemovedFromChannelEnabled = null, string notificationsRemovedFromChannelTemplate = null, string notificationsRemovedFromChannelSound = null, bool? notificationsInvitedToChannelEnabled = null, string notificationsInvitedToChannelTemplate = null, string notificationsInvitedToChannelSound = null, Uri preWebhookUrl = null, Uri postWebhookUrl = null, Twilio.Http.HttpMethod webhookMethod = null, List<string> webhookFilters = null, int? limitsChannelMembers = null, int? limitsUserChannels = null, ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){FriendlyName = friendlyName, DefaultServiceRoleSid = defaultServiceRoleSid, DefaultChannelRoleSid = defaultChannelRoleSid, DefaultChannelCreatorRoleSid = defaultChannelCreatorRoleSid, ReadStatusEnabled = readStatusEnabled, ReachabilityEnabled = reachabilityEnabled, TypingIndicatorTimeout = typingIndicatorTimeout, ConsumptionReportInterval = consumptionReportInterval, NotificationsNewMessageEnabled = notificationsNewMessageEnabled, NotificationsNewMessageTemplate = notificationsNewMessageTemplate, NotificationsNewMessageSound = notificationsNewMessageSound, NotificationsNewMessageBadgeCountEnabled = notificationsNewMessageBadgeCountEnabled, NotificationsAddedToChannelEnabled = notificationsAddedToChannelEnabled, NotificationsAddedToChannelTemplate = notificationsAddedToChannelTemplate, NotificationsAddedToChannelSound = notificationsAddedToChannelSound, NotificationsRemovedFromChannelEnabled = notificationsRemovedFromChannelEnabled, NotificationsRemovedFromChannelTemplate = notificationsRemovedFromChannelTemplate, NotificationsRemovedFromChannelSound = notificationsRemovedFromChannelSound, NotificationsInvitedToChannelEnabled = notificationsInvitedToChannelEnabled, NotificationsInvitedToChannelTemplate = notificationsInvitedToChannelTemplate, NotificationsInvitedToChannelSound = notificationsInvitedToChannelSound, PreWebhookUrl = preWebhookUrl, PostWebhookUrl = postWebhookUrl, WebhookMethod = webhookMethod, WebhookFilters = webhookFilters, LimitsChannelMembers = limitsChannelMembers, LimitsUserChannels = limitsUserChannels};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ServiceResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ServiceResource object represented by the provided JSON </returns> 
        public static ServiceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The default_service_role_sid
        /// </summary>
        [JsonProperty("default_service_role_sid")]
        public string DefaultServiceRoleSid { get; private set; }
        /// <summary>
        /// The default_channel_role_sid
        /// </summary>
        [JsonProperty("default_channel_role_sid")]
        public string DefaultChannelRoleSid { get; private set; }
        /// <summary>
        /// The default_channel_creator_role_sid
        /// </summary>
        [JsonProperty("default_channel_creator_role_sid")]
        public string DefaultChannelCreatorRoleSid { get; private set; }
        /// <summary>
        /// The read_status_enabled
        /// </summary>
        [JsonProperty("read_status_enabled")]
        public bool? ReadStatusEnabled { get; private set; }
        /// <summary>
        /// The reachability_enabled
        /// </summary>
        [JsonProperty("reachability_enabled")]
        public bool? ReachabilityEnabled { get; private set; }
        /// <summary>
        /// The typing_indicator_timeout
        /// </summary>
        [JsonProperty("typing_indicator_timeout")]
        public int? TypingIndicatorTimeout { get; private set; }
        /// <summary>
        /// The consumption_report_interval
        /// </summary>
        [JsonProperty("consumption_report_interval")]
        public int? ConsumptionReportInterval { get; private set; }
        /// <summary>
        /// The limits
        /// </summary>
        [JsonProperty("limits")]
        public object Limits { get; private set; }
        /// <summary>
        /// The pre_webhook_url
        /// </summary>
        [JsonProperty("pre_webhook_url")]
        public string PreWebhookUrl { get; private set; }
        /// <summary>
        /// The post_webhook_url
        /// </summary>
        [JsonProperty("post_webhook_url")]
        public string PostWebhookUrl { get; private set; }
        /// <summary>
        /// The webhook_method
        /// </summary>
        [JsonProperty("webhook_method")]
        public string WebhookMethod { get; private set; }
        /// <summary>
        /// The webhook_filters
        /// </summary>
        [JsonProperty("webhook_filters")]
        public List<string> WebhookFilters { get; private set; }
        /// <summary>
        /// The notifications
        /// </summary>
        [JsonProperty("notifications")]
        public object Notifications { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private ServiceResource()
        {

        }
    }

}