﻿/*
 * Copyright 2023 Tm Technologies Co.,Ltd.
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;

namespace TmCloud.SDK.Core
{
    public interface IProgressRequest
    {
        double ProgressInterval { get; set; }
        EventHandler<TransferStatus> TransferProgress { get; set; }
        ProgressTypeEnum ProgressType { get; set; }
    }

    public enum ProgressTypeEnum
    {
        /// <summary>
        ///     Specify that the upload progress is refreshed each time a specified number of bytes is uploaded.
        /// </summary>
        ByBytes,

        /// <summary>
        ///     Specify that the upload is refreshed every several seconds.
        /// </summary>
        BySeconds
    }
}
