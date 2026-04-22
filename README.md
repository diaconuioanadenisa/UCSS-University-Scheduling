# UCSS - University Course Scheduling System
**Thecnology:** C# (.NET Core) & SQL Server

UCSS is an information system designed to assist academic faculties in managing their educational resources and automating the course planning process efficiently.The administration of the faculty’s resources will be carried out in two main stages:
Stage 1: Administrators will define the academic infrastructure, specifying details for classrooms (type: lecture hall, seminar room, or laboratory), capacity, and available equipment.
Stage 2: The system will manage the teaching staff database, storing information such as weekly availability slots, departments, and specialized subjects.
Students and teachers will interact with the system through dedicated interfaces. Students can view personalized timetables filtered by their specific group and year of study, while teachers can update their availability and view assigned class locations.The system uses a specialized allocation and conflict detection engine to process scheduling requests. For each course, administrative staff will select an appropriate room and an available teacher based on capacity and timing constraints. The system will automatically detect and block overlaps (double-booking) to ensure resource integrity. Once finalized, the schedule can be exported in standardized PDF, CSV, and XML formats.The information system will allow graphical visualization of room occupancy and teacher workloads through intuitive, color-coded interfaces.

## Project Objective
The digitization of the faculty course planning process to prevent overlaps of personnel and academic resources.

## Implemented Components
Data Model: C# classes for Teachers, Rooms, and Courses.

Validation Engine: An algorithm that detects if a teacher or a room is already allocated.

Database: Complete SQL schema for data persistence.

## How It Works
The system receives a scheduling request and verifies within the existing entries if the TimeSlot is available for both the specific room and the assigned teacher. The schedule is saved only if no conflicts are detected.

