using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade cannot be negative!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The minimum grade cannot be negative!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("The maximum grade cannot be smaller than the minimum grade");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("There must be a comment!");
        }



        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }

}
