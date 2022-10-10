// See https://aka.ms/new-console-template for more information


using MementoDesignPatternUI;

TextEdit text = new TextEdit();
text.editor = new Editor();
text.editor.Content = "Ok this works";
text.editor.FontName = "Sague UI";
text.editor.FontSize = 15;
Console.WriteLine(text.editor.FontName);

History<EditorState<Editor>> history = new History<EditorState<Editor>>();
history.Push(text.GetData());


text.editor = new Editor();
text.editor.Content = "Ok this works";
text.editor.FontName = "Segue UI";
text.editor.FontSize = 15;
history.Push(text.GetData());
Console.WriteLine(text.editor.FontName);

text.editor = new Editor();
text.editor.Content = "Ok this works";
text.editor.FontName = "Segue UI";
text.editor.FontSize = 8;
history.Push(text.GetData());
Console.WriteLine(text.editor.FontSize.ToString());


text.editor = new Editor();
text.editor.Content = "Well testing this";
text.editor.FontName = "Times";
text.editor.FontSize = 6;
history.Push(text.GetData());
Console.WriteLine(text.editor.FontSize.ToString()+" : "+ text.editor.FontName);

Console.WriteLine("Undo Press");

text.restore(history.Pop());
Console.WriteLine(text.editor.FontSize.ToString() + " : " + text.editor.FontName);

text.restore(history.Pop());
Console.WriteLine(text.editor.FontSize.ToString() + " : " + text.editor.FontName);

Console.WriteLine("Done!");
Console.ReadLine();

