// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Abstract base class for skills.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-predefined-skills"
    /// />
    /// </summary>
    public partial class Skill
    {
        /// <summary>
        /// Initializes a new instance of the Skill class.
        /// </summary>
        public Skill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Skill class.
        /// </summary>
        /// <param name="inputs">Inputs of the skills could be a column in the
        /// source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in an
        /// Azure Search index, or a value that can be consumed as an input by
        /// another skill.</param>
        /// <param name="name">The name of the skill which uniquely identifies
        /// it within the skillset. A skill with no name defined will be given
        /// a default name of its 1-based index in the skills array, prefixed
        /// with the character '#'.</param>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">Represents the level at which operations take
        /// place, such as the document root or document content (for example,
        /// /document or /document/content). The default is /document.</param>
        public Skill(IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, string name = default(string), string description = default(string), string context = default(string))
        {
            Name = name;
            Description = description;
            Context = context;
            Inputs = inputs;
            Outputs = outputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the skill which uniquely identifies it
        /// within the skillset. A skill with no name defined will be given a
        /// default name of its 1-based index in the skills array, prefixed
        /// with the character '#'.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the skill which describes the
        /// inputs, outputs, and usage of the skill.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets represents the level at which operations take place,
        /// such as the document root or document content (for example,
        /// /document or /document/content). The default is /document.
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets inputs of the skills could be a column in the source
        /// data set, or the output of an upstream skill.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IList<InputFieldMappingEntry> Inputs { get; set; }

        /// <summary>
        /// Gets or sets the output of a skill is either a field in an Azure
        /// Search index, or a value that can be consumed as an input by
        /// another skill.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public IList<OutputFieldMappingEntry> Outputs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Inputs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Inputs");
            }
            if (Outputs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Outputs");
            }
            if (Inputs != null)
            {
                foreach (var element in Inputs)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Outputs != null)
            {
                foreach (var element1 in Outputs)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}