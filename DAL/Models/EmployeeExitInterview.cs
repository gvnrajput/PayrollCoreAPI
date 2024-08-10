using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeExitInterview
{
    public int EmployeeExitId { get; set; }

    public int? EmployeeId { get; set; }

    public string? WhyHaveYouDecidedToLeaveTheCompany { get; set; }

    public string? HaveYouSharedYourConcernsWithAnyoneInTheCompanyPriorToDecidingToLeaveWhatWasTheResponse { get; set; }

    public string? WasASingleEventResponsibleForYourDecisionToLeave { get; set; }

    public string? WhatDoesYourNewCompanyOfferThatEncouragedYouToAcceptTheirOfferAndLeaveThisCompany { get; set; }

    public string? WhatDoYouValueAboutTheCompany { get; set; }

    public string? WhatDidYouDislikeAboutTheCompany { get; set; }

    public string? TheQualityOfSupervisionIsImportantToMostPeopleAtWorkHowWasYourRelationshipWithYourManager { get; set; }

    public string? WhatCouldYourSupervisorDoToImproveHisOrHerManagementStyleAndSkill { get; set; }

    public string? WhatAreYourViewsAboutManagementAndLeadershipInGeneralInTheCompany { get; set; }

    public string? WhatDidYouLikeMostAboutYourJob { get; set; }

    public string? WhatDidYouDislikeAboutYourJobWhatWouldYouChangeAboutYourJob { get; set; }

    public string? JobSupportNecessaryIfNotWhatWasMissing { get; set; }

    public string? WeTryToBeAnEmployeeOrientedMoraleAndMotivationMoraleAndMotivationInTheCompany { get; set; }

    public string? WereYourJobResponsibilitiesCharacterizedCorrectlyDuringTheInterviewProcessAndOrientation { get; set; }

    public string? DidYouHaveClearGoalsAndKnowWhatWasExpectedOfYouInYourJob { get; set; }

    public string? DidYouReceiveAdequateFeedbackAboutYourPerformanceDayDayAndInThePerformanceDevelopmentPlanningProcess { get; set; }

    public string? DidYouClearlyUnderstandAndFeelAPartOfTheAccomplishmentOfTheCompanyMissionAndGoals { get; set; }

    public string? DescribeYourExperienceOfTheCompanysCommitmentToQualityCustomerService { get; set; }

    public string? DidTheManagementOfTheCompanyCareAboutYouAndHelpYouAccomplishYourGoals { get; set; }

    public string? WhatWouldYouRecommendToHelpUsCreateABetterWorkplace { get; set; }

    public string? DoThePoliciesAndProceduresOfTheCompanyHelpCreateAWellmanagedConsistentAndFairAreClearlyDefined { get; set; }

    public string? DescribeTheQualitiesAndCharacteristicsOfThePersonWhoIsMostLikelyToSucceedInThisCompany { get; set; }

    public string? WhatAreTheKeyQualitiesAndSkillsWeShouldSeekInYourReplacement { get; set; }

    public string? RecommendationsRegardingOurCompensationBenefitsAndOtherRewardAndRecognitionEfforts { get; set; }

    public string? WhatWouldMakeYouConsiderWorkingForThisCompanyAgainInTheFuture { get; set; }

    public string? WouldYouRecommendTheCompanyToYourFriendsAndFamily { get; set; }

    public string? CanYouOfferAnyOtherCommentsThatWillEnableUsToUnderstandAndWhatWeCanDoToBecomeABetterCompany { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? Isctive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
