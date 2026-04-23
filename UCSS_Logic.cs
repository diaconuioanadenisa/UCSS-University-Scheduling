using System;
using System.Collections.Generic;
using System.Linq;

namespace UCSS_Project
{
    // Modelele de date conform diagramei
    public class Teacher {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Room {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }

    public class Course {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ScheduleEntry {
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public Room Room { get; set; }
        public string TimeSlot { get; set; }
    }

    // Logica de gestionare a orarului
    public class Scheduler
    {
        private List<ScheduleEntry> _entries = new List<ScheduleEntry>();

        public string AddSchedule(Course course, Teacher teacher, Room room, string timeSlot)
        {
            // Verificare conflict sala sau profesor
            var conflict = _entries.FirstOrDefault(e => e.TimeSlot == timeSlot && 
                          (e.Room.Id == room.Id || e.Teacher.Id == teacher.Id));

            if (conflict != null)
            {
                if (conflict.Room.Id == room.Id)
                    return $"ERROR: Room {room.Name} is already occupied at {timeSlot}!";
                
                return $"EROARE: Teacher {teacher.Name} already has a class at {timeSlot}!";
            }

            _entries.Add(new ScheduleEntry { Course = course, Teacher = teacher, Room = room, TimeSlot = timeSlot });
            return "SUCCESS: Course scheduled correctly.";
        }
    }

    class Program {
        static void Main() {
            Scheduler myScheduler = new Scheduler();
            
            // Exemplu de date
            var t1 = new Teacher { Id = 1, Name = "Popescu Ion" };
            var r1 = new Room { Id = 101, Name = "Room 201" };
            var c1 = new Course { Id = 1, Name = "Operating systems" };

            Console.WriteLine(myScheduler.AddSchedule(c1, t1, r1, "Monday 08:00"));
            // Incercam sa punem alt curs in aceeasi sala la aceeasi ora
            Console.WriteLine(myScheduler.AddSchedule(new Course{Id=2}, new Teacher{Id=2}, r1, "Monday 08:00"));
        }
    }
}
