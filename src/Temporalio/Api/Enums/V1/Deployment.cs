// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temporal/api/enums/v1/deployment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Temporalio.Api.Enums.V1 {

  /// <summary>Holder for reflection information generated from temporal/api/enums/v1/deployment.proto</summary>
  public static partial class DeploymentReflection {

    #region Descriptor
    /// <summary>File descriptor for temporal/api/enums/v1/deployment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeploymentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZ0ZW1wb3JhbC9hcGkvZW51bXMvdjEvZGVwbG95bWVudC5wcm90bxIVdGVt",
            "cG9yYWwuYXBpLmVudW1zLnYxKsQBChZEZXBsb3ltZW50UmVhY2hhYmlsaXR5",
            "EicKI0RFUExPWU1FTlRfUkVBQ0hBQklMSVRZX1VOU1BFQ0lGSUVEEAASJQoh",
            "REVQTE9ZTUVOVF9SRUFDSEFCSUxJVFlfUkVBQ0hBQkxFEAESMQotREVQTE9Z",
            "TUVOVF9SRUFDSEFCSUxJVFlfQ0xPU0VEX1dPUktGTE9XU19PTkxZEAISJwoj",
            "REVQTE9ZTUVOVF9SRUFDSEFCSUxJVFlfVU5SRUFDSEFCTEUQA0KHAQoYaW8u",
            "dGVtcG9yYWwuYXBpLmVudW1zLnYxQg9EZXBsb3ltZW50UHJvdG9QAVohZ28u",
            "dGVtcG9yYWwuaW8vYXBpL2VudW1zL3YxO2VudW1zqgIXVGVtcG9yYWxpby5B",
            "cGkuRW51bXMuVjHqAhpUZW1wb3JhbGlvOjpBcGk6OkVudW1zOjpWMWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Temporalio.Api.Enums.V1.DeploymentReachability), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Specify the reachability level for a deployment so users can decide if it is time to
  /// decommission the deployment.
  /// </summary>
  public enum DeploymentReachability {
    /// <summary>
    /// Reachability level is not specified.
    /// </summary>
    [pbr::OriginalName("DEPLOYMENT_REACHABILITY_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The deployment is reachable by new and/or open workflows. The deployment cannot be
    /// decommissioned safely.
    /// </summary>
    [pbr::OriginalName("DEPLOYMENT_REACHABILITY_REACHABLE")] Reachable = 1,
    /// <summary>
    /// The deployment is not reachable by new or open workflows, but might be still needed by
    /// Queries sent to closed workflows. The deployment can be decommissioned safely if user does
    /// not query closed workflows.
    /// </summary>
    [pbr::OriginalName("DEPLOYMENT_REACHABILITY_CLOSED_WORKFLOWS_ONLY")] ClosedWorkflowsOnly = 2,
    /// <summary>
    /// The deployment is not reachable by any workflow because all the workflows who needed this
    /// deployment went out of retention period. The deployment can be decommissioned safely.
    /// </summary>
    [pbr::OriginalName("DEPLOYMENT_REACHABILITY_UNREACHABLE")] Unreachable = 3,
  }

  #endregion

}

#endregion Designer generated code
