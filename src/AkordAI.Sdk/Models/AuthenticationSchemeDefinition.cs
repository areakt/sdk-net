using AkordAI.Sdk.Models.Authentication;

namespace AkordAI.Sdk.Models;

/// <summary>
/// Represents the base class for all authentication scheme definitions
/// </summary>
[DataContract]
public abstract record AuthenticationSchemeDefinition
    : Extendable
{

    /// <summary>
    /// Gets the name of the authentication scheme
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public abstract string Scheme { get; }

    /// <summary>
    /// Gets/sets the name of the secret, if any, used to configure the authentication scheme
    /// </summary>
    [DataMember(Name = "use", Order = 1), JsonPropertyName("use"), JsonPropertyOrder(1), YamlMember(Alias = "use", Order = 1)]
    public virtual string? Use { get; set; }

    /// <summary>
    /// Gets/sets the definition of the placement, if any, of the resolved authentication parameter
    /// </summary>
    [DataMember(Name = "placement", Order = 99), JsonPropertyName("placement"), JsonPropertyOrder(99), YamlMember(Alias = "placement", Order = 99)]
    public virtual AuthenticationParameterPlacementDefinition? Placement { get; set; }

}
