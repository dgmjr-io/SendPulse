namespace SendPulse.Api.Abstractions;

public interface ISendPulseApi
    : IAccountApi,
        IBotsApi,
        ICampaignsApi,
        IChatsApi,
        IContactsApi,
        IFlowsApi,
        ITriggersApi,
        IVariablesApi
{ }
