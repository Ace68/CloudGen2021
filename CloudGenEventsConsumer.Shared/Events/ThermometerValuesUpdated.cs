﻿using CloudGenEventsConsumer.Shared.CustomTypes;
using FourSolid.Athena.Messages.Events;
using FourSolid.Common.ValueObjects;
using FourSolid.IoT.Shared.ValueObjects;
using CommunicationDate = CloudGenEventsConsumer.Shared.CustomTypes.CommunicationDate;
using DeviceName = CloudGenEventsConsumer.Shared.CustomTypes.DeviceName;
using EventId = CloudGenEventsConsumer.Shared.CustomTypes.EventId;

namespace CloudGenEventsConsumer.Shared.Events
{
    public sealed class ThermometerValuesUpdated : DomainEvent
    {
        public readonly EventId EventId;
        public readonly DeviceId DeviceId;
        public readonly DeviceName DeviceName;
        public readonly Temperature Temperature;
        public readonly UnitOfMeasurement UnitOfMeasurement;
        public readonly CommunicationDate CommunicationDate;

        public ThermometerValuesUpdated(DeviceId deviceId, EventId eventId, DeviceName deviceName,
            Temperature temperature, UnitOfMeasurement unitOfMeasurement, CommunicationDate communicationDate,AccountInfo who, When when)
            : base(deviceId, who, when)
        {
            this.EventId = eventId;

            this.DeviceId = deviceId;
            this.DeviceName = deviceName;
            this.Temperature = temperature;
            this.UnitOfMeasurement = unitOfMeasurement;
            this.CommunicationDate = communicationDate;
        }
    }
}