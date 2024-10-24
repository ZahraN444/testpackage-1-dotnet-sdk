// <copyright file="Cycle.cs" company="APIMatic">
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
    /// Cycle.
    /// </summary>
    public class Cycle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cycle"/> class.
        /// </summary>
        public Cycle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cycle"/> class.
        /// </summary>
        /// <param name="employeeId">employee_id.</param>
        public Cycle(
            string employeeId)
        {
            this.EmployeeId = employeeId;
        }

        /// <summary>
        /// The ID of the employee this membership is associated with.
        /// </summary>
        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Cycle : ({string.Join(", ", toStringOutput)})";
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
            return obj is Cycle other &&                ((this.EmployeeId == null && other.EmployeeId == null) || (this.EmployeeId?.Equals(other.EmployeeId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EmployeeId = {(this.EmployeeId == null ? "null" : this.EmployeeId)}");
        }
    }
}