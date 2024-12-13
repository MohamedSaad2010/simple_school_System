import java.util.Scanner;

class Participant {
    protected String name;
    protected String ID;
    protected String email;

    public Participant(String name, String ID, String email) {
        this.name = name;
        this.ID = ID;
        this.email = email;
    }

    public String getName() {
        return name;
    }

    public String getID() {
        return ID;
    }

    public String getEmail() {
        return email;
    }
}


class Student extends Participant {
    private int attendance;

    public Student(String name, String ID, String email) {
        super(name, ID, email);
        this.attendance = 0;
    }

    public void markAttendance() {
        attendance++;
    }

    public int getAttendance() {
        return attendance;
    }

    @Override
    public String toString() {
        return "Student: Name=" + name + ", ID=" + ID + ", Email=" + email + ", Attendance=" + attendance;
    }
}

class Instructor extends Participant {

    public Instructor(String name, String ID, String email) {
        super(name, ID, email);
    }

    @Override
    public String toString() {
        return "Instructor: Name=" + name + ", ID=" + ID + ", Email=" + email;
    }
}

class Courses {
    private String courseName;
    private String courseCode;
    private Instructor courseInstructor;

    public Courses(String courseName, String courseCode, Instructor courseInstructor) {
        this.courseName = courseName;
        this.courseCode = courseCode;
        this.courseInstructor = courseInstructor;
    }

    public String getCourseName() {
        return courseName;
    }

    public String getCourseCode() {
        return courseCode;
    }

    public Instructor getCourseInstructor() {
        return courseInstructor;
    }
}


class Grade {
    private String studentID;
    private String courseName;
    private double grade;

    public Grade(String studentID, String courseName, double grade) {
        this.studentID = studentID;
        this.courseName = courseName;
        this.grade = grade;
    }

    public String getStudentID() {
        return studentID;
    }

    public String getCourseName() {
        return courseName;
    }

    public double getGrade() {
        return grade;
    }

    public static void recordGrade(Grade[] grades, String studentID, String courseName, double grade) {
        for (int i = 0; i < grades.length; i++) {
            if (grades[i] == null) {
                grades[i] = new Grade(studentID, courseName, grade);
                return;
            }
        }
        System.out.println("No space to record more grades.");
    }

    public static double calculateTotalGrade(Grade[] grades) {
        double total = 0;
        for (Grade g : grades) {
            if (g != null) {
                total += g.getGrade();
            }
        }
        return total;
    }

    public static double calculateAverageGrade(Grade[] grades) {
        int count = 0;
        double total = 0;
        for (Grade g : grades) {
            if (g != null) {
                total += g.getGrade();
                count++;
            }
        }
        return count == 0 ? 0 : total / count;
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter student name: ");
        String studentName = scanner.nextLine();
        System.out.print("Enter student ID: ");
        String studentID = scanner.nextLine();
        System.out.print("Enter student email: ");
        String studentEmail = scanner.nextLine();

        Student student1 = new Student(studentName, studentID, studentEmail);

        System.out.print("Enter instructor name: ");
        String instructorName = scanner.nextLine();
        System.out.print("Enter instructor ID: ");
        String instructorID = scanner.nextLine();
        System.out.print("Enter instructor email: ");
        String instructorEmail = scanner.nextLine();

        Instructor instructor1 = new Instructor(instructorName, instructorID, instructorEmail);

        System.out.print("Enter course name: ");
        String courseName = scanner.nextLine();
        System.out.print("Enter course code: ");
        String courseCode = scanner.nextLine();

        Courses course1 = new Courses(courseName, courseCode, instructor1);

        System.out.println(student1);
        System.out.println(instructor1);
        System.out.println("Course: Name=" + course1.getCourseName() + ", Code=" + course1.getCourseCode() + ", Instructor=" + course1.getCourseInstructor().getName());

        Grade[] grades = new Grade[10];

        boolean addingGrades = true;
        while (addingGrades) {
            System.out.print("Enter course name for grade: ");
            String gradeCourse = scanner.nextLine();
            System.out.print("Enter grade: ");
            double gradeValue = scanner.nextDouble();
            scanner.nextLine(); 
            Grade.recordGrade(grades, studentID, gradeCourse, gradeValue);

            System.out.print("Do you want to add another grade? (yes/no): ");
            String response = scanner.nextLine();
            if (response.equalsIgnoreCase("no")) {
                addingGrades = false;
            }
        }

        System.out.println("Total Grade: " + Grade.calculateTotalGrade(grades));
        System.out.println("Average Grade: " + Grade.calculateAverageGrade(grades));

        System.out.print("How many times has the student attended? ");
        int attendanceCount = scanner.nextInt();
        for (int i = 0; i < attendanceCount; i++) {
            student1.markAttendance();
        }

        System.out.println("Updated " + student1);

        
        scanner.close();
    }
}
