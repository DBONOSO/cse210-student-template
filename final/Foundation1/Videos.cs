
class Video
{
 public string _title = "";
 public string _author = "";
 public List<Comment> _comments = new List<Comment>();
 public int _length;


 public Video()
 {
 }

 public Video(string title, string author, int length)
 {
  _title = title;
  _author = author;
  _length = length;
 }

 public void ShowComments()
 {
  foreach(Comment comment in _comments)
  {
   Console.WriteLine ($"{comment._commentPerson}: {comment._commentText}");
   Console.WriteLine("");
  }
 }
 public int GetNumComments()
 {
  return _comments.Count;
 }
}