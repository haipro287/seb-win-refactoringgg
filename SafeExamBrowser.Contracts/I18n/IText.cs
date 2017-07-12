﻿/*
 * Copyright (c) 2017 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Contracts.I18n
{
	public interface IText
	{
		/// <summary>
		/// Gets the text associated with the specified key. If the key was not found, a default text indicating
		/// that the given key is not configured shall be returned.
		/// </summary>
		string Get(Key key);
	}
}
