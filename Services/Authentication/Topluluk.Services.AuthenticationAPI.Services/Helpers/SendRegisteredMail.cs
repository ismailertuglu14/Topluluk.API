﻿using MassTransit;
using Topluluk.Shared.Constants;
using Topluluk.Shared.Messages;


namespace Topluluk.Services.AuthenticationAPI.Services.Helpers
{
    public class SendRegisteredMail
    {
        private readonly ISendEndpointProvider _endpointProvider;

        public SendRegisteredMail(ISendEndpointProvider endpointProvider)
        {
            _endpointProvider = endpointProvider;
        }

        public async Task send(string firstName, string lastName, string email)
        {
            var sendEndpoint = await _endpointProvider.GetSendEndpoint(new Uri(QueueConstants.SUCCESSFULLY_REGISTERED_MAIL));
            var registerMessage = new SuccessfullyRegisteredCommand
            {
                To = email,
                FullName = $"{firstName} {lastName}"
            };
            sendEndpoint.Send<SuccessfullyRegisteredCommand>(registerMessage);

        }
	}
}

