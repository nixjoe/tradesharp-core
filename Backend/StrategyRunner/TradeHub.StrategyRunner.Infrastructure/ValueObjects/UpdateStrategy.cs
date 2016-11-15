/***************************************************************************** 
* Copyright 2016 Aurora Solutions 
* 
*    http://www.aurorasolutions.io 
* 
* Aurora Solutions is an innovative services and product company at 
* the forefront of the software industry, with processes and practices 
* involving Domain Driven Design(DDD), Agile methodologies to build 
* scalable, secure, reliable and high performance products.
* 
* TradeSharp is a C# based data feed and broker neutral Algorithmic 
* Trading Platform that lets trading firms or individuals automate 
* any rules based trading strategies in stocks, forex and ETFs. 
* TradeSharp allows users to connect to providers like Tradier Brokerage, 
* IQFeed, FXCM, Blackwood, Forexware, Integral, HotSpot, Currenex, 
* Interactive Brokers and more. 
* Key features: Place and Manage Orders, Risk Management, 
* Generate Customized Reports etc 
* 
* Licensed under the Apache License, Version 2.0 (the "License"); 
* you may not use this file except in compliance with the License. 
* You may obtain a copy of the License at 
* 
*    http://www.apache.org/licenses/LICENSE-2.0 
* 
* Unless required by applicable law or agreed to in writing, software 
* distributed under the License is distributed on an "AS IS" BASIS, 
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
* See the License for the specific language governing permissions and 
* limitations under the License. 
*****************************************************************************/


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHub.StrategyRunner.Infrastructure.ValueObjects
{
    public class UpdateStrategy
    {
        /// <summary>
        /// Unique Key to identify strategy instance
        /// </summary>
        private string _strategyKey;

        /// <summary>
        /// Indicates whether the strategy is running/stopped
        /// </summary>
        private bool _isRunning;

        /// <summary>
        /// Unique Key to identify strategy instance
        /// </summary>
        public string StrategyKey
        {
            get { return _strategyKey; }
            set { _strategyKey = value; }
        }

        /// <summary>
        /// Indicates whether the strategy is running/stopped
        /// </summary>
        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }

        /// <summary>
        /// Argument Constructor
        /// </summary>
        /// <param name="strategyKey">Unique Key to identify strategy instance</param>
        /// <param name="isRunning">Indicates whether the strategy is running/stopped</param>
        public UpdateStrategy(string strategyKey, bool isRunning)
        {
            _strategyKey = strategyKey;
            _isRunning = isRunning;
        }
    }
}