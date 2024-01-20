Dictionary<string, List<decimal>> students = new();

byte numberOfStudents = byte.Parse(Console.ReadLine()!);
for (int i = 0; i < numberOfStudents; i++)
{
    string[] studentInfo = Console.ReadLine()!.Split();
    string studentName = studentInfo[0];
    decimal studentGrade = decimal.Parse(studentInfo[1]);

    if (students.TryGetValue(studentName, out var student)) student.Add(studentGrade);
    else students[studentName] = new List<decimal> {studentGrade};
}

foreach (var student in students) Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(s => s.ToString("F2")))} (avg: {student.Value.Average():F2})");