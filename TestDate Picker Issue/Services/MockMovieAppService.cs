namespace Date_Picker_Issue.MovieApp
{
    public class MockMovieAppService : IMovieAppService
    {
        public Task<List<NowPlayingType>> GetNowPlaying()
        {
            return Task.FromResult<List<NowPlayingType>>(new());
        }
    }
}