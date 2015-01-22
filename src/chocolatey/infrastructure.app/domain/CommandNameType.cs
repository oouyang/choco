﻿// Copyright © 2011 - Present RealDimensions Software, LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// 
// You may obtain a copy of the License at
// 
// 	http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace chocolatey.infrastructure.app.domain
{
    using System.ComponentModel;

    public enum CommandNameType
    {
        [Description("list - lists remote or local packages")] list,
        [Description("search - searches remote or local packages")] search,
        [Description("install - installs packages from various sources")] install,
        [Description("pin - suppress upgrades to a package")] pin,
        //[Description("update - updates package index")] update,
        [Description("upgrade - upgrades packages from various sources")] upgrade,
        [Description("uninstall - uninstalls a package")] uninstall,
        [Description("source - view and configure default sources")] source,
        // [Description("config - view and change configuration")] config,
        [Description("unpackself - have chocolatey set it self up")] unpackself,
        [Description("pack - packages up a nuspec to a compiled nupkg")] pack,
        [Description("push - pushes a compiled nupkg")] push,
        [Description("new - generates files necessary for a chocolatey package")] @new,
        [Description("apikey - retrieves or saves an apikey for a particular source")] apikey,
    }
}