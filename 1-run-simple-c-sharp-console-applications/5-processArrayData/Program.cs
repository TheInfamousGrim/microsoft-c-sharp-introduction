// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };  

/* ------------------ Sum all assignments for each student ------------------ */
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tGrade\n");
foreach (string name in studentNames) {
    // Initialize variables
    int studentSum = 0;
    string studentGrade = "F";
    int[] studentScores = new int[5];
    decimal studentScore = 0;

    // Determine which student's scores to use
    switch (name) {
        case "Sophia":
            studentScores = sophiaScores;
            break;
        case "Andrew":
            studentScores = andrewScores;
            break;
        case "Emma":
            studentScores = emmaScores;
            break;
        case "Logan":
            studentScores = loganScores;
            break;
        case "Becky":
            studentScores = beckyScores;
            break;
        case "Chris":
            studentScores = chrisScores;
            break;
        case "Eric":
            studentScores = ericScores;
            break;
        case "Gregor":
            studentScores = gregorScores;
            break;
    }

    // Sum the student's scores
    int gradedAssignments = 0;

    foreach (int score in studentScores) {
        gradedAssignments++;

        if (gradedAssignments <= currentAssignments) {
            studentSum += score;
        } else {
            studentSum += score / 10;
        }
    }

    // Calculate the student's average score
    studentScore = (decimal)studentSum / currentAssignments;

    // Determine the student's letter grade
    switch (studentScore) {
        case var d when d >= 97:
            studentGrade = "A+";
            break;
        case var d when d >= 93:
            studentGrade = "A";
            break;
        case var d when d >= 90:
            studentGrade = "A-";
            break;
        case var d when d >= 87:
            studentGrade = "B+";
            break;
        case var d when d >= 83:
            studentGrade = "B";
            break;
        case var d when d >= 80:
            studentGrade = "B-";
            break;
        case var d when d >= 77:
            studentGrade = "C+";
            break;
        case var d when d >= 73:
            studentGrade = "C";
            break;
        case var d when d >= 70:
            studentGrade = "C-";
            break;
        case var d when d >= 67:
            studentGrade = "D+";
            break;
        case var d when d >= 63:
            studentGrade = "D";
            break;
        case var d when d >= 60:
            studentGrade = "D-";
            break;
        default:
            studentGrade = "F";
            break;
    }

    Console.WriteLine($"{name}:\t\t{studentScore}\t{studentGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();