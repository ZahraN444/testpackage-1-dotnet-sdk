// <copyright file="HubMembershipInvitation.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// HubMembershipInvitation.
    /// </summary>
    public class HubMembershipInvitation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembershipInvitation"/> class.
        /// </summary>
        public HubMembershipInvitation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembershipInvitation"/> class.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="events">events.</param>
        public HubMembershipInvitation(
            Models.Sender sender,
            string recipient,
            Models.InvitationEvents events)
        {
            this.Sender = sender;
            this.Recipient = recipient;
            this.Events = events;
        }

        /// <summary>
        /// Information about the origin account of the invitation.
        /// </summary>
        [JsonProperty("sender")]
        public Models.Sender Sender { get; set; }

        /// <summary>
        /// The email address for the invitations recipient.
        /// </summary>
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the invitation's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.InvitationEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubMembershipInvitation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is HubMembershipInvitation other &&                ((this.Sender == null && other.Sender == null) || (this.Sender?.Equals(other.Sender) == true)) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Sender = {(this.Sender == null ? "null" : this.Sender.ToString())}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient)}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}