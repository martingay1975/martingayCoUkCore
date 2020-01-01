using DiaryEntryUI.Models;

namespace DiaryEntryUI.Application
{
    public class DiaryRepositoryFactory
    {
        private static IDiaryRepository _diaryRepository;

        public IDiaryRepository Create()
        {
            if (_diaryRepository == null)
            {
                var configuration = new ConfigurationFactory().Create();

                var diaryHelper = new DiarySerialization();
                var diaryAssembler = new DiaryAssembler();

                _diaryRepository = new DiaryRepository(diaryHelper, configuration, diaryAssembler);
            }

            return _diaryRepository;
        }

        public void Reset()
        {
            _diaryRepository = null;
        }
    }
}