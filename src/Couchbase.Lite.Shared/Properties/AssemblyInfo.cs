//
// Author:
//     Zachary Gramana  <zack@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc
// Copyright (c) 2014 .NET Foundation
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//
// Copyright (c) 2014 Couchbase, Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
// except in compliance with the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.
//

using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System;

[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]
[assembly: AssemblyTitle ("Couchbase.Lite")]
[assembly: AssemblyDescription ("A lightweight, document-oriented (NoSQL), syncable database engine for .NET")]
#if ENTERPRISE
#else
[assembly: AssemblyConfiguration ("Community Edition")]
#endif
[assembly: AssemblyCompany ("Couchbase")]
[assembly: AssemblyProduct ("Couchbase Lite")]
[assembly: AssemblyCopyright ("2015")]
// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.
// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Net45.Tests")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Android.Tests")]
[assembly: InternalsVisibleTo("CouchbaseLiteiOSTests")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Net35.Tests")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Unity.Tests")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Listener")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Listener.Bonjour")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Storage.SystemSQLite")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Storage.CustomSQLite")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Storage.SQLCipher")]
[assembly: InternalsVisibleTo("Couchbase.Lite.Storage.ForestDB")]
[assembly: InternalsVisibleTo("Listener")]