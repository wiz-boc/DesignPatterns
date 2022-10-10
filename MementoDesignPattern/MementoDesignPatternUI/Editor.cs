using System;
namespace MementoDesignPatternUI
{
    public class TextEdit {
        public Editor editor;

        public EditorState<Editor> GetData() {
            return new EditorState<Editor>(editor);
        }

        public void restore(EditorState<Editor> state) {
            editor = state.GetData();
        }

        public Editor GetEditor() {
            return editor;
        }
    }

	public class Editor
	{
		public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

    }

    public class EditorState<T>
    {
        private T Data { get; set; }

        public EditorState(T data)
        {
            this.Data = data; 
        }

        public T GetData() { return Data; }

    }

    public class History<T> {
        private List<T> states = new List<T>();
        public void Push(T state) {
            states.Add(state);
        }
        public T Pop() {
            int lastIndex = states.Count() - 1;
            T lastState = states[lastIndex];
            states.Remove(lastState);
            return lastState;
        }
    }
}

