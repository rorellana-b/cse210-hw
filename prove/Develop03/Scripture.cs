class Scripture{

public Reference _reference;
List<Word> _words = new List<Word>();

public Scripture(Reference reference, string text){

    _reference = reference;
    //_words = text.Split(' ').Select(w => new Word(w)).ToList();
}

public void HideRandomWords(int numberToHide){

}

public string GetDispayText(){
    return "";
}

public bool IsCompletelyHidden(){
    return true;
}

}