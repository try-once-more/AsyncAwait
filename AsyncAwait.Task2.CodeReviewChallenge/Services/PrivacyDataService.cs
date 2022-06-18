﻿using System.Threading.Tasks;

namespace AsyncAwait.Task2.CodeReviewChallenge.Services;

public class PrivacyDataService : IPrivacyDataService
{
    private Task<string> _policyTask;

    public Task<string> GetPrivacyDataAsync()
    {
        return _policyTask ??= Task.FromResult("This Policy describes how async/await processes your personal data," +
                                     "but it may not address all possible data processing scenarios.");
    }

    ////In case if the cost of creating a state machine is lower than creating a task
    //public async Task<string> GetPrivacyDataAsync()
    //{
    //    return "This Policy describes how async/await processes your personal data," +
    //                                 "but it may not address all possible data processing scenarios.";
    //}
}
