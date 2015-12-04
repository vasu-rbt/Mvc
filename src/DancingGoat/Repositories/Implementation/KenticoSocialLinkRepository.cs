﻿using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine.Types;

namespace DancingGoat.Repositories.Implementation
{
    /// <summary>
    /// Represents a collection of links to social networks.
    /// </summary>
    public class KenticoSocialLinkRepository : ISocialLinkRepository
    {
        private readonly string mSiteName;
        private readonly string mCultureName;
        private readonly bool mLatestVersionEnabled;


        /// <summary>
        /// Initializes a new instance of the <see cref="KenticoSocialLinkRepository"/> class that returns links from the specified site in the specified language.
        /// If the requested link doesn't exist in specified language then its default culture version is returned.
        /// </summary>
        /// <param name="siteName">The code name of a site.</param>
        /// <param name="cultureName">The name of a culture.</param>
        /// <param name="latestVersionEnabled">Indicates whether the repository will provide the most recent version of pages.</param>
        public KenticoSocialLinkRepository(string siteName, string cultureName, bool latestVersionEnabled)
        {
            mSiteName = siteName;
            mCultureName = cultureName;
            mLatestVersionEnabled = latestVersionEnabled;
        }


        /// <summary>
        /// Returns an enumerable collection of links to social networks ordered by a position in the content tree.
        /// </summary>
        /// <returns>An enumerable collection of links to social networks ordered by a position in the content tree.</returns>
        public IEnumerable<SocialLink> GetSocialLinks()
        {
            return SocialLinkProvider.GetSocialLinks()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(mSiteName)
                .Culture(mCultureName)
                .CombineWithDefaultCulture()
                .OrderByAscending("NodeOrder")
                .ToList();
        }
    }
}