﻿// Copyright 2007-2011 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Topshelf.Options
{
	using System;
	using HostConfigurators;
	using Internal;


	public class StartOption :
		Option
	{
		public void ApplyTo([NotNull] HostConfigurator configurator)
		{
			if (configurator == null)
				throw new ArgumentNullException("configurator");

			var startConfigurator = new StartConfigurator();

			configurator.AddConfigurator(startConfigurator);
		}
	}
}