﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using SafeExamBrowser.Contracts.Communication;
using SafeExamBrowser.Contracts.Communication.Messages;
using SafeExamBrowser.Contracts.Communication.Responses;
using SafeExamBrowser.Contracts.Logging;
using SafeExamBrowser.Core.Communication;

namespace SafeExamBrowser.Runtime.Communication
{
	internal class RuntimeHost : BaseHost, IRuntimeHost
	{
		public RuntimeHost(string address, ILogger logger) : base(address, logger)
		{
		}

		public override IConnectResponse Connect(Guid? token = null)
		{
			// TODO
			throw new NotImplementedException();
		}

		public override void Disconnect(IMessage message)
		{
			// TODO
			throw new NotImplementedException();
		}

		public override IResponse Send(IMessage message)
		{
			// TODO
			throw new NotImplementedException();
		}
	}
}
