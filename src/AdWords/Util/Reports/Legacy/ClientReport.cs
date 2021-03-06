// Copyright 2011, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Author: api.anash@gmail.com (Anash P. Oommen)

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google.Api.Ads.AdWords.Util.Reports.Legacy {
  /// <summary>
  /// Represents a report downloaded from the server.
  /// </summary>
  [Obsolete("This class is deprecated, use Google.Api.Ads.AdWords.Util.Reports.ReportUtilities " +
      "instead. See http://goo.gl/LX016X for migration details.")]
  public class ClientReport {
    /// <summary>
    /// The path to which the report was downloaded.
    /// </summary>
    string path;

    /// <summary>
    /// The report contents in memory.
    /// </summary>
    byte[] contents;

    /// <summary>
    /// Gets or sets the path.
    /// </summary>
    public string Path {
      get {
        return path;
      }
      internal set {
        path = value;
      }
    }

    /// <summary>
    /// Gets the report contents.
    /// </summary>
    public byte[] Contents {
      get {
        return contents;
      }
      internal set {
        contents = value;
      }
    }

    /// <summary>
    /// Gets the report contents.
    /// </summary>
    public string Text {
      get {
        return Encoding.UTF8.GetString(contents);
      }
    }
  }
}
