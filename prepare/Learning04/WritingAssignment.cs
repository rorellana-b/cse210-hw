public class WritingAssignment : Assigment {
    private string _title;

    public WritingAssignment(string Name, string Topic, string title) : base (Name, Topic){

        _title = title;
    }

    public string GetWritingInformation (){
        string studentName = getStudenName();

        return ($"{_title} by {studentName}");
    }

}