
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

/* ------------------ Sum all assignments for each student ------------------ */
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
foreach (string name in studentNames) {
    // Initialize variables
    int studentSum = 0;
    int studentExamSum = 0;
    int extraCreditSum = 0;
    decimal studentScore = 0;
    decimal studentExamScore = 0;
    decimal extraCreditScore = 0;
    decimal studentExtraCreditScore = 0;
    string studentGrade = "F";
    int[] studentScores = new int[5];


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
    }

    // Sum the student's scores
    int gradedAssignments = 0;

    foreach (int score in studentScores) {
        gradedAssignments++;

        if (gradedAssignments <= currentAssignments) {
            studentExamSum += score;
        }

        if (gradedAssignments > currentAssignments) {
            extraCreditSum += score;
        }

        if (gradedAssignments <= currentAssignments) {
            studentSum += score;
        } else {
            studentSum += score / 10;
        }
    }

    // Calculate the student's average score
    studentScore = (decimal)studentSum / currentAssignments;
    studentExamScore = (decimal)studentExamSum / currentAssignments;
    studentExtraCreditScore = (decimal)extraCreditSum / (studentScores.Length - currentAssignments);

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

    Console.WriteLine($"{name}:\t\t{studentExamScore}\t\t{studentScore}\t{studentGrade}\t{studentExtraCreditScore} ({(decimal)studentScore - studentExamScore} pts)");
}
