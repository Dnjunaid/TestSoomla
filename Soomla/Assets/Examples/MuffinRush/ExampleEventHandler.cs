/// Copyright (C) 2012-2014 Soomla Inc.
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///      http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.

using System;
using System.Collections.Generic;

namespace Soomla.Store.Example {

	/// <summary>
	/// This class contains functions that receive events that they are subscribed to.
	///
	/// THIS IS JUST AN EXAMPLE. IF YOU WANT TO USE IT YOU NEED TO INSTANTIATE IT SOMEWHERE.
	/// </summary>
	public class ExampleEventHandler {

		/// <summary>
		/// Constructor.
		/// Subscribes to potential events.
		/// </summary>
		public ExampleEventHandler () {
			StoreEvents.OnMarketPurchase += onMarketPurchase;
			StoreEvents.OnMarketRefund += onMarketRefund;
			StoreEvents.OnItemPurchased += onItemPurchased;
			StoreEvents.OnGoodEquipped += onGoodEquipped;
			StoreEvents.OnGoodUnEquipped += onGoodUnequipped;
			StoreEvents.OnGoodUpgrade += onGoodUpgrade;
			StoreEvents.OnBillingSupported += onBillingSupported;
			StoreEvents.OnBillingNotSupported += onBillingNotSupported;
			StoreEvents.OnMarketPurchaseStarted += onMarketPurchaseStarted;
			StoreEvents.OnItemPurchaseStarted += onItemPurchaseStarted;
			StoreEvents.OnCurrencyBalanceChanged += onCurrencyBalanceChanged;
			StoreEvents.OnGoodBalanceChanged += onGoodBalanceChanged;
			StoreEvents.OnMarketPurchaseCancelled += onMarketPurchaseCancelled;
			StoreEvents.OnMarketPurchaseDeferred += onMarketPurchaseDeferred;
			StoreEvents.OnRestoreTransactionsStarted += onRestoreTransactionsStarted;
			StoreEvents.OnRestoreTransactionsFinished += onRestoreTransactionsFinished;
			StoreEvents.OnSoomlaStoreInitialized += onSoomlaStoreInitialized;
			StoreEvents.OnUnexpectedStoreError += onUnexpectedStoreError;

#if UNITY_ANDROID && !UNITY_EDITOR
			StoreEvents.OnIabServiceStarted += onIabServiceStarted;
			StoreEvents.OnIabServiceStopped += onIabServiceStopped;
#endif
		}

		/// <summary>
		/// Handles unexpected errors with error code.
		/// </summary>
		/// <param name="errorCode">The error code.</param>
		public void onUnexpectedStoreError(UnexpectedStoreErrorEvent e) {
			SoomlaUtils.LogError ("ExampleEventHandler", "error with code: " + e.getErrorCode());
		}

		/// <summary>
		/// Handles a market purchase event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		/// <param name="purchaseToken">Purchase token.</param>
		public void onMarketPurchase(MarketPurchaseEvent e) {

		}

		/// <summary>
		/// Handles a market refund event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onMarketRefund(MarketRefundEvent e) {

		}

		/// <summary>
		/// Handles an item purchase event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onItemPurchased(ItemPurchasedEvent e) {

		}

		/// <summary>
		/// Handles a good equipped event.
		/// </summary>
		/// <param name="good">Equippable virtual good.</param>
		public void onGoodEquipped(GoodEquippedEvent e) {

		}

		/// <summary>
		/// Handles a good unequipped event.
		/// </summary>
		/// <param name="good">Equippable virtual good.</param>
		public void onGoodUnequipped(GoodUnEquippedEvent e) {

		}

		/// <summary>
		/// Handles a good upgraded event.
		/// </summary>
		/// <param name="good">Virtual good that is being upgraded.</param>
		/// <param name="currentUpgrade">The current upgrade that the given virtual
		/// good is being upgraded to.</param>
		public void onGoodUpgrade(GoodUpgradeEvent e) {

		}

		/// <summary>
		/// Handles a billing supported event.
		/// </summary>
		public void onBillingSupported(BillingSupportedEvent e) {

		}

		/// <summary>
		/// Handles a billing NOT supported event.
		/// </summary>
		public void onBillingNotSupported(BillingNotSupportedEvent e) {

		}

		/// <summary>
		/// Handles a market purchase started event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onMarketPurchaseStarted(MarketPurchaseStartedEvent e) {

		}

		/// <summary>
		/// Handles an item purchase started event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onItemPurchaseStarted(ItemPurchaseStartedEvent e) {

		}

		/// <summary>
		/// Handles an item purchase cancelled event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		public void onMarketPurchaseCancelled(MarketPurchaseCancelledEvent e) {
		}
        
		/// <summary>
		/// Handles an item purchase deferred event.
		/// </summary>
		/// <param name="pvi">Purchasable virtual item.</param>
		/// <param name="payload">Developer supplied payload.</param>
		public void onMarketPurchaseDeferred(MarketPurchaseDeferredEvent e) {
		}
        
		/// <summary>
		/// Handles a currency balance changed event.
		/// </summary>
		/// <param name="virtualCurrency">Virtual currency whose balance has changed.</param>
		/// <param name="balance">Balance of the given virtual currency.</param>
		/// <param name="amountAdded">Amount added to the balance.</param>
		public void onCurrencyBalanceChanged(CurrencyBalanceChangedEvent e) {

		}

		/// <summary>
		/// Handles a good balance changed event.
		/// </summary>
		/// <param name="good">Virtual good whose balance has changed.</param>
		/// <param name="balance">Balance.</param>
		/// <param name="amountAdded">Amount added.</param>
		public void onGoodBalanceChanged(GoodBalanceChangedEvent e) {

		}

		/// <summary>
		/// Handles a restore Transactions process started event.
		/// </summary>
		public void onRestoreTransactionsStarted(RestoreTransactionsStartedEvent e) {

		}

		/// <summary>
		/// Handles a restore transactions process finished event.
		/// </summary>
		/// <param name="success">If set to <c>true</c> success.</param>
		public void onRestoreTransactionsFinished(RestoreTransactionsFinishedEvent e) {

		}

		/// <summary>
		/// Handles a store controller initialized event.
		/// </summary>
		public void onSoomlaStoreInitialized(SoomlaStoreInitializedEvent e) {
			
		}

#if UNITY_ANDROID && !UNITY_EDITOR
		public void onIabServiceStarted() {

		}
		public void onIabServiceStopped() {

		}
#endif
	}
}
