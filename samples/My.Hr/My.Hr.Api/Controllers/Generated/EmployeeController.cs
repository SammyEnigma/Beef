/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Beef;
using Beef.AspNetCore.WebApi;
using Beef.Entities;
using My.Hr.Business;
using My.Hr.Common.Entities;
using RefDataNamespace = My.Hr.Common.Entities;

namespace My.Hr.Api.Controllers
{
    /// <summary>
    /// Provides the <see cref="Employee"/> Web API functionality.
    /// </summary>
    [Route("api/v1/employees")]
    public partial class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The <see cref="IEmployeeManager"/>.</param>
        public EmployeeController(IEmployeeManager manager)
            { _manager = Check.NotNull(manager, nameof(manager)); EmployeeControllerCtor(); }

        partial void EmployeeControllerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="Employee"/>.
        /// </summary>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        /// <returns>The selected <see cref="Employee"/> where found.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Get(Guid id)
        {
            return new WebApiGet<Employee?>(this, () => _manager.GetAsync(id),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);
        }

        /// <summary>
        /// Creates a new <see cref="Employee"/>.
        /// </summary>
        /// <param name="value">The <see cref="Employee"/>.</param>
        /// <returns>The created <see cref="Employee"/>.</returns>
        [HttpPost("")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.Created)]
        public IActionResult Create([FromBody] Employee value)
        {
            return new WebApiPost<Employee>(this, () => _manager.CreateAsync(WebApiActionBase.Value(value)),
                operationType: OperationType.Create, statusCode: HttpStatusCode.Created, alternateStatusCode: null);
        }

        /// <summary>
        /// Updates an existing <see cref="Employee"/>.
        /// </summary>
        /// <param name="value">The <see cref="Employee"/>.</param>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        /// <returns>The updated <see cref="Employee"/>.</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        public IActionResult Update([FromBody] Employee value, Guid id)
        {
            return new WebApiPut<Employee>(this, () => _manager.UpdateAsync(WebApiActionBase.Value(value), id),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }

        /// <summary>
        /// Patches an existing <see cref="Employee"/>.
        /// </summary>
        /// <param name="value">The <see cref="JToken"/> that contains the patch content for the <see cref="Employee"/>.</param>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        /// <returns>The patched <see cref="Employee"/>.</returns>
        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        public IActionResult Patch([FromBody] JToken value, Guid id)
        {
            return new WebApiPatch<Employee>(this, value, () => _manager.GetAsync(id), (__value) => _manager.UpdateAsync(__value, id),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }

        /// <summary>
        /// Deletes the specified <see cref="Employee"/>.
        /// </summary>
        /// <param name="id">The Id.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult Delete(Guid id)
        {
            return new WebApiDelete(this, () => _manager.DeleteAsync(id),
                operationType: OperationType.Delete, statusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Gets the <see cref="EmployeeBaseCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="firstName">The First Name.</param>
        /// <param name="lastName">The Last Name.</param>
        /// <param name="genders">The Genders (see <see cref="RefDataNamespace.Gender"/>).</param>
        /// <param name="startFrom">The Start From.</param>
        /// <param name="startTo">The Start To.</param>
        /// <param name="isIncludeTerminated">Indicates whether Is Include Terminated.</param>
        /// <returns>The <see cref="EmployeeBaseCollection"/></returns>
        [HttpGet("")]
        [ProducesResponseType(typeof(EmployeeBaseCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GetByArgs(string? firstName = default, string? lastName = default, List<string>? genders = default, DateTime? startFrom = default, DateTime? startTo = default, [FromQuery(Name = "includeTerminated")] bool? isIncludeTerminated = default)
        {
            var args = new EmployeeArgs { FirstName = firstName, LastName = lastName, GendersSids = genders, StartFrom = startFrom, StartTo = startTo, IsIncludeTerminated = isIncludeTerminated };
            return new WebApiGet<EmployeeBaseCollectionResult, EmployeeBaseCollection, EmployeeBase>(this, () => _manager.GetByArgsAsync(args, WebApiQueryString.CreatePagingArgs(this)),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Terminates an existing <see cref="Employee"/>.
        /// </summary>
        /// <param name="value">The <see cref="TerminationDetail"/>.</param>
        /// <param name="id">The <see cref="Employee"/> identifier.</param>
        /// <returns>The updated <see cref="Employee"/>.</returns>
        [HttpPost("{id}/terminate")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        public IActionResult Terminate([FromBody] TerminationDetail value, Guid id)
        {
            return new WebApiPost<Employee>(this, () => _manager.TerminateAsync(WebApiActionBase.Value(value), id),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }
    }
}

#pragma warning restore
#nullable restore