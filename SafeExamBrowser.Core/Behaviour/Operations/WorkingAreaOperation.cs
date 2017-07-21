﻿/*
 * Copyright (c) 2017 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.Behaviour;
using SafeExamBrowser.Contracts.Configuration;
using SafeExamBrowser.Contracts.I18n;
using SafeExamBrowser.Contracts.Logging;
using SafeExamBrowser.Contracts.Monitoring;
using SafeExamBrowser.Contracts.UserInterface;

namespace SafeExamBrowser.Core.Behaviour.Operations
{
	class WorkingAreaOperation : IOperation
	{
		private ILogger logger;
		private IProcessMonitor processMonitor;
		private ITaskbar taskbar;
		private IWorkingArea workingArea;

		public ISplashScreen SplashScreen { private get; set; }

		public WorkingAreaOperation(ILogger logger, IProcessMonitor processMonitor, ITaskbar taskbar, IWorkingArea workingArea)
		{
			this.logger = logger;
			this.processMonitor = processMonitor;
			this.taskbar = taskbar;
			this.workingArea = workingArea;
		}

		public void Perform()
		{
			logger.Info("--- Initializing working area ---");
			SplashScreen.UpdateText(Key.SplashScreen_WaitExplorerTermination, true);

			processMonitor.CloseExplorerShell();
			processMonitor.StartMonitoringExplorer();

			// TODO
			// - Minimizing all open windows
			// - Emptying clipboard

			SplashScreen.UpdateText(Key.SplashScreen_InitializeWorkingArea);
			workingArea.InitializeFor(taskbar);
		}

		public void Revert()
		{
			logger.Info("--- Restoring working area ---");
			SplashScreen.UpdateText(Key.SplashScreen_RestoreWorkingArea);

			// TODO
			// - Restore all windows?
			// - Emptying clipboard

			workingArea.Reset();

			SplashScreen.UpdateText(Key.SplashScreen_WaitExplorerStartup, true);

			processMonitor.StopMonitoringExplorer();
			processMonitor.StartExplorerShell();
		}
	}
}