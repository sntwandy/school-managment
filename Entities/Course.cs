using Core.Entities.Types;
using System;

namespace Core.Entities
{
    class Course
    {
        public string UniqueId {  get; private set; }
        public string Name { get; set; }
        public JournayTypes Journay {  get; set; }

        public Course() => UniqueId = Guid.NewGuid().ToString();
    }
}
