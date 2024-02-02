public class  Assigment {
    private string _studentName;
    private string _topic;

    public Assigment(string Name, string Topic){
        _studentName = Name;
        _topic = Topic;
    }

    public string getStudenName (){
        return _studentName;
    }

    public string getTopic(){
        return _topic;
    }

    public string GetSummary(){
        return _studentName + " - " + _topic;  
    }
}