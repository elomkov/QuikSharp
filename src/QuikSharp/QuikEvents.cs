﻿// Copyright (C) 2014 Victor Baybekov
using System;

namespace QuikSharp {

    /// <summary>
    /// Handler for events without arguments
    /// </summary>
    public delegate void VoidHandler();
    public delegate void OnInitHandler(string path, int port);
    public delegate void OnStopHandler(int signal);

    internal class QuikEvents : IQuikEvents {
        public event EventHandler OnAccountBalance;
        public event EventHandler OnAccountPosition;
        public event EventHandler OnAllTrade;
        /// <summary>
        /// Функция вызывается терминалом QUIK при смене сессии и при выгрузке файла qlua.dll. 
        /// </summary>
        public event VoidHandler OnCleanUp;
        internal void OnCleanUpCall() { OnCleanUp(); }
        /// <summary>
        /// Функция вызывается перед закрытием терминала QUIK. 
        /// </summary>
        public event VoidHandler OnClose;
        internal void OnCloseCall() { OnClose(); }
        /// <summary>
        /// Функция вызывается терминалом QUIK при установлении связи с сервером QUIK. 
        /// </summary>
        public event VoidHandler OnConnected;
        internal void OnConnectedCall() { OnConnected(); }
        public event EventHandler OnDepoLimit;
        public event EventHandler OnDepoLimitDelete;
        /// <summary>
        /// Функция вызывается терминалом QUIK при отключении от сервера QUIK. 
        /// </summary>
        public event VoidHandler OnDisconnected;
        internal void OnDisconnectedCall() { OnDisconnected(); }
        public event EventHandler OnFirm;
        public event EventHandler OnFuturesClientHolding;
        public event EventHandler OnFuturesLimitChange;
        public event EventHandler OnFuturesLimitDelete;
        
        public event OnInitHandler OnInit;
        internal void OnInitCall(string path, int port) { OnInit(path, port); }

        public event EventHandler OnMoneyLimit;
        public event EventHandler OnMoneyLimitDelete;
        public event EventHandler OnNegDeal;
        public event EventHandler OnNegTrade;
        public event EventHandler OnOrder;
        public event EventHandler OnParam;
        public event EventHandler OnQuote;
        public event OnStopHandler OnStop;
        internal void OnStopCall(int signal) { OnStop(signal); }
        public event EventHandler OnStopOrder;
        public event EventHandler OnTrade;
        public event EventHandler OnTransReply;
    }
}
