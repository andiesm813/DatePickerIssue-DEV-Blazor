namespace Date_Picker_Issue.MovieApp
{
    public interface IMovieAppService
    {
        Task<List<NowPlayingType>> GetNowPlaying();
    }
}