;;;; * Last problem

(setq exp "[+ [+ 3 4] [+ [+ 1 2] [+ 1 3]]]")

(defun f (exp)
  (+
   ;; (substring exp 1 1)
   (string-to-number (substring exp 3 4))
   (string-to-number (substring exp 5 6))))

(with-current-buffer "TDD"
  (insert exp)
  (goto-char (point-min))
  (goto-char (point-min))
  (while (search-forward "]" nil t)
    (yes-or-no-p "Eval sub-group?")
    (setq p1 (point))
    (setq p0 (search-backward "["))
    (setq sub-exp (buffer-substring p0 p1))
    (setq res (f sub-exp))
    (search-forward sub-exp nil t 1)
    (replace-match (number-to-string res) nil t)))
