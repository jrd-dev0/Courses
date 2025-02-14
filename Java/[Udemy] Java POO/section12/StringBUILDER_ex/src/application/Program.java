package application;

import java.time.Instant;
import java.time.LocalDateTime;
import java.time.ZoneId;
import java.time.format.DateTimeFormatter;

import entities.Comment;
import entities.Post;

public class Program {

	public static void main(String[] args) {
		
        LocalDateTime localDateTime = LocalDateTime.parse("21/06/2018 13:05:44", DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss"));
        Instant moment = localDateTime.atZone(ZoneId.systemDefault()).toInstant();
        String title = "Traveling to New Zealand";
        String content = "I'm going to visit this wonderful country!";
        int likes = 12;
        
        Post post = new Post(moment, title, content, likes);
        
        post.addComment(new Comment("Have a nice trip"));
        post.addComment(new Comment("Wow that's awesome!"));
        
        LocalDateTime localDateTime2 = LocalDateTime.parse("28/07/2018 23:14:19", DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss"));
        Instant moment2 = localDateTime2.atZone(ZoneId.systemDefault()).toInstant();
        String title2 = "Good night guys";
        String content2 = "See you tomorrow";
        int likes2 = 5;
                
        Post post2 = new Post(moment2, title2, content2, likes2);
        
        post2.addComment(new Comment("Good night"));
        post2.addComment(new Comment("May the Force be with you"));
        
        
        System.out.println(post);
        System.out.println(post2);
	}
}