﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Razor.Serialization;

namespace Microsoft.VisualStudio.LiveShare.Razor.Serialization;

internal class ProjectSnapshotHandleProxyJsonConverter : ObjectJsonConverter<ProjectSnapshotHandleProxy>
{
    public static readonly ProjectSnapshotHandleProxyJsonConverter Instance = new();

    protected override ProjectSnapshotHandleProxy ReadFromProperties(JsonDataReader reader)
    {
        var filePath = reader.ReadNonNullUri(nameof(ProjectSnapshotHandleProxy.FilePath));
        var configuration = reader.ReadNonNullObject(nameof(ProjectSnapshotHandleProxy.Configuration), ObjectReaders.ReadConfigurationFromProperties);
        var rootNamespace = reader.ReadStringOrNull(nameof(ProjectSnapshotHandleProxy.RootNamespace));
        var projectWorkspaceState = reader.ReadObjectOrNull(nameof(ProjectSnapshotHandleProxy.ProjectWorkspaceState), ObjectReaders.ReadProjectWorkspaceStateFromProperties);

        return new(filePath, configuration, rootNamespace, projectWorkspaceState);
    }

    protected override void WriteProperties(JsonDataWriter writer, ProjectSnapshotHandleProxy value)
    {
        writer.Write(nameof(value.FilePath), value.FilePath);
        writer.WriteObject(nameof(value.Configuration), value.Configuration, ObjectWriters.WriteProperties);
        writer.WriteIfNotNull(nameof(value.RootNamespace), value.RootNamespace);
        writer.WriteObjectIfNotNull(nameof(value.ProjectWorkspaceState), value.ProjectWorkspaceState, ObjectWriters.WriteProperties);
    }
}
