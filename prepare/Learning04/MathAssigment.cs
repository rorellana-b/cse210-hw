using System.Security.Principal;



public class MathAssigment : Assigment{

    private string _textbookSection;
    private string _problem;

    public MathAssigment (string studentName, string Topic, string TextbookSection, string Problem):base (studentName, Topic){
        
        _textbookSection = TextbookSection;
        _problem = Problem;
    }

    public string GetHommeworkList(){
        return $"Section {_textbookSection} -- Problem {_problem}";
    }
}