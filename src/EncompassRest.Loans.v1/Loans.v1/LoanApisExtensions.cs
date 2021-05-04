﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.ResourceLocks;
using EncompassRest.Services;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.v1
{
    public static class LoanApisExtensions
    {
        public static ILoanApisV1? V1 { get; set; }

        private static ILoanApisV1 GetV1(ILoanApis loanApis)
        {
            var v1 = V1;
            if (loanApis is LoanApis a)
            {
                v1 = (ILoanApisV1)a.ExtensionData.GetOrAdd("v1", k => new LoanApisV1(a.Client, a.LoanApis, a.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loanApis, nameof(loanApis));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves the loan lock information with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id of the lock to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ResourceLock> GetLockAsync(this ILoanApis loanApis, string lockId, CancellationToken cancellationToken = default) => GetV1(loanApis).GetLockAsync(lockId, cancellationToken);

        /// <summary>
        /// Retrieves a list of loan lock information from Encompass.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ResourceLock>> GetLocksAsync(this ILoanApis loanApis, CancellationToken cancellationToken = default) => GetV1(loanApis).GetLocksAsync(cancellationToken);

        /// <summary>
        /// Retrieves metadata from the loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanMetadata> GetMetadataAsync(this ILoanApis loanApis, CancellationToken cancellationToken = default) => GetV1(loanApis).GetMetadataAsync(cancellationToken);

        /// <summary>
        /// Retrieves metadata from the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetMetadataRawAsync(this ILoanApis loanApis, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanApis).GetMetadataRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> LockAsync(this ILoanApis loanApis, ResourceLockType lockType, CancellationToken cancellationToken = default) => LockAsync(loanApis, lockType, force: false, cancellationToken);

        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to lock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> LockAsync(this ILoanApis loanApis, ResourceLockType lockType, bool force, CancellationToken cancellationToken = default) => LockAsync(loanApis, lockType.Validate(nameof(lockType)).GetValue()!, force, cancellationToken);

        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> LockAsync(this ILoanApis loanApis, string lockType, CancellationToken cancellationToken = default) => LockAsync(loanApis, lockType, force: false, cancellationToken);

        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to lock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> LockAsync(this ILoanApis loanApis, string lockType, bool force, CancellationToken cancellationToken = default) => GetV1(loanApis).LockAsync(lockType, force, cancellationToken);

        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryUnlockAsync(this ILoanApis loanApis, string lockId, CancellationToken cancellationToken = default) => TryUnlockAsync(loanApis, lockId, force: false, cancellationToken);

        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryUnlockAsync(this ILoanApis loanApis, string lockId, bool force, CancellationToken cancellationToken = default) => GetV1(loanApis).TryUnlockAsync(lockId, force, cancellationToken);

        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UnlockAsync(this ILoanApis loanApis, string lockId, CancellationToken cancellationToken = default) => UnlockAsync(loanApis, lockId, force: false, cancellationToken);

        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UnlockAsync(this ILoanApis loanApis, string lockId, bool force, CancellationToken cancellationToken = default) => GetV1(loanApis).UnlockAsync(lockId, force, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> ExportToMismoAsync(this ILoanApis loanApis, MismoFormat format, CancellationToken cancellationToken = default) => ExportToMismoAsync(loanApis, format.Validate(nameof(format)).GetValue()!, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a byte array.
        /// </summary>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<byte[]> ExportToMismoAsync(this ILoanApis loanApis, string format, CancellationToken cancellationToken = default) => GetV1(loanApis).ExportToMismoAsync(format, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> ExportToMismoStreamAsync(this ILoanApis loanApis, MismoFormat format, CancellationToken cancellationToken = default) => ExportToMismoStreamAsync(loanApis, format.Validate(nameof(format)).GetValue()!, cancellationToken);

        /// <summary>
        /// Use this API transforms an Encompass Loan to a MISMO 3.4 XML format for ULAD (DU or LPA) and iLAD as a stream.
        /// </summary>
        /// <param name="format">Format that you want to export the loan to.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Stream> ExportToMismoStreamAsync(this ILoanApis loanApis, string format, CancellationToken cancellationToken = default) => GetV1(loanApis).ExportToMismoStreamAsync(format, cancellationToken);
    }
}