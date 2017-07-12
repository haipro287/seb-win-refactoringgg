﻿/*
 * Copyright (c) 2017 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;

namespace SafeExamBrowser.Contracts.Logging
{
	public interface IThreadInfo : ICloneable
	{
		/// <summary>
		/// The id of the thread.
		/// </summary>
		int Id { get; }

		/// <summary>
		/// The thread's name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// A flag indicating whether the thread has a name.
		/// </summary>
		bool HasName { get; }
	}
}
