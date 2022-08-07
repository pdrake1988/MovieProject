using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ReviewServiceAsync : IReviewServiceAsync
    {
        IReviewRepositoryAsync reviewRepository;
        public ReviewServiceAsync(IReviewRepositoryAsync reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }
        public async Task<int> CreateAsync(ReviewModel review)
        {
            Review newReview = new Review
            {
                Id = review.Id,
                MovieId = review.MovieId,
                Rating = review.Rating,
                ReviewText = review.ReviewText,
            };
            return await reviewRepository.InsertAsync(newReview);
        }

        public async Task<IEnumerable<ReviewModel>> GetAllAsync()
        {
            var reviews = await reviewRepository.GetAllAsync();
            if (reviews != null)
            {
                List<ReviewModel> listReviews = new List<ReviewModel>();
                foreach (var review in reviews)
                {
                    ReviewModel reviewModel = new ReviewModel()
                    {
                        Id = review.Id,
                        MovieId = review.MovieId,
                        Rating = review.Rating,
                        ReviewText = review.ReviewText,
                    };
                    listReviews.Add(reviewModel);
                }
                return listReviews;
            }
            return null;
        }
    }
}
