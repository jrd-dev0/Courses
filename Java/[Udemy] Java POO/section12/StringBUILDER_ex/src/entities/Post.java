package entities;

import java.time.Instant;
import java.time.ZoneId;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;

public class Post {
	
	private Instant date;
	private String title;
	private String content;
	private Integer likes;
	
	private List<Comment> comments = new ArrayList<>();
	
	public Post(Instant date, String title, String content, int likes) {
		this.date = date;
        this.title = title;
        this.content = content;
        this.likes = likes;;
	}

	public Instant getDate() {
		return date;
	}

	public void setDate(Instant date) {
		this.date = date;
	}

	public String getTitle() {
		return title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	public String getContent() {
		return content;
	}

	public void setContent(String content) {
		this.content = content;
	}

	public Integer getLikes() {
		return likes;
	}

	public void setLikes(Integer likes) {
		this.likes = likes;
	}
	
	public void addComment(Comment coment) {
		comments.add(coment);
	}
	
	public void removeComment(Comment coment) {
        comments.remove(coment);
    }
	
	public List<Comment> getComments() {
        return comments;
    }
	
	@Override
    public String toString() {
		DateTimeFormatter fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss").withZone(ZoneId.systemDefault());
        StringBuilder sb = new StringBuilder();
        sb.append(String.format("%s%n", getTitle()));
        sb.append(String.format("%d Likes - %s%n", getLikes(), fmt.format(getDate())));
        sb.append(String.format("%s%n%n", getContent()));
        sb.append(String.format("Comments:%n"));
        
        for (Comment coment : comments) {
            sb.append(String.format("%s%n", coment.getText()));
        }
        
        sb.append(String.format("----------------------------%n"));
        
        return sb.toString();
    }

}
